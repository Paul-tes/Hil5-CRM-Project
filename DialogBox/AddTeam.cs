using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hil5_CRM_Project.model;
using Hil5_CRM_Project.Properties;

namespace Hil5_CRM_Project.DialogBox
{
    public partial class AddTeam : Form
    {
        public AddTeam()
        {
            InitializeComponent();
            lbl_required1.Hide();
            lbl_required2.Hide();
            lbl_required3.Hide();
            lbl_required4.Hide();
            lbl_required5.Hide();
            lbl_required6.Hide();
            lbl_required7.Hide();
        }

        string imgLocation = "";
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_email.Focus();
            }
        }


        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_department.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Name.Focus();
        }

        //SAVE method
        private void btn_save_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            //Validation


            //Email
            Regex rEmail = new Regex(@"^[^@\s]+@[^@\s\.]+\.[^@\.\s]+$");
            if (rEmail.IsMatch(txt_email.Text))
            {
                team.email = txt_email.Text;
            }
            else
            {
                txt_email.BorderColor = Color.Red;
                txt_email.BorderThickness = 2;
                txt_email.Text = "";
                txt_email.PlaceholderText = "ex: abc1@gmail.com";
                if (String.IsNullOrEmpty(txt_email.Text))
                    lbl_required3.Show();
            }


            //Name 

            /*
            //works partially
            Regex rFullName = new Regex(@"^[a-zA-Z]+ [a-zA-Z]+$");
            if (rFullName.IsMatch(txt_Name.Text))
            {
                team.name = txt_Name.Text;
            }
            else
            {
                txt_Name.BorderColor = Color.Red;
                txt_Name.BorderThickness = 2;
                txt_Name.Text = "";
                txt_Name.PlaceholderText = "first last";
                if (String.IsNullOrEmpty(txt_Name.Text))
                    lbl_required1.Show();
            }
            */
            team.name = txt_Name.Text;


            //works fine
            Regex rPassword = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$");

            if (rPassword.IsMatch(txt_password.Text))
            {
                team.password = txt_password.Text;
            }
            else
            {
                txt_password.BorderColor = Color.Red;
                txt_password.BorderThickness = 2;
                msg_dialogError.Caption = "Password Error";
                msg_dialogError.Text = "Has minimum 8 characters in length.\n At least one letter,\n one digit and special character\n ";
                msg_dialogError.Show();
                if (String.IsNullOrEmpty(txt_password.Text))
                    lbl_required4.Show();
            }

            //Validation

            //type
            if (cmb_type.SelectedItem == null)
            {
                cmb_type.BorderThickness = 2;
                cmb_type.BorderColor = Color.Red;
                lbl_required5.Show();

            }
            else
            {
                team.type = cmb_type.SelectedItem.ToString();
            }

            //Gender 
            if (radBtn_Male.Checked)
                team.gender = "Male";
            else if (radBtn_Female.Checked)
                team.gender = "Female";
            else
            {
                lbl_required2.Show();
            }


            //department
            if (String.IsNullOrEmpty(txt_department.Text))
            {
                lbl_required6.Show();
                txt_department.BorderThickness = 2;
                txt_department.BorderColor = Color.Red;
            }
            else
            {
                team.departement = txt_department.Text;
            }
            //role
            if (cmb_role.SelectedItem == null)
            {
                cmb_role.BorderThickness = 2;
                cmb_role.BorderColor = Color.Red;
                lbl_required7.Show();

            }
            else
            {
                team.role = cmb_role.SelectedItem.ToString();
            }

            //status
            team.status = chk_status.Checked;


            //picture
            team.picture = null;
            if (imgLocation != "")
            {
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(fs);
                team.picture = brs.ReadBytes((int)fs.Length);
            }
            else
            {
                team.picture = null;
            }

            // saving Team to database.
            DbAccess dbAccess = new DbAccess();
            dbAccess.AddTeam(team);

        }


        //image to array
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        // array to image
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void btn_Showpwd_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                btn_hidePwd.BringToFront();
                txt_password.PasswordChar = '\0';
            }
        }

        private void btn_hidePwd_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '\0')
            {
                btn_Showpwd.BringToFront();
                txt_password.PasswordChar = '*';
            }
        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
    
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)| *.jpg | PNG files(.*png) | *.png | All Files(*.*) | *.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                    pictureBox_team.ImageLocation = imgLocation;

                }
            }
            catch (Exception)
            {
                msg_dialogError.Show("An error has occured");
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            cnt++;
            if (cnt == 8)
            {
                txt_password.BorderColor = Color.Green;
            }
        }


    }
}
