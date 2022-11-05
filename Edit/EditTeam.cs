using Hil5_CRM_Project.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hil5_CRM_Project.Edit
{
    public partial class EditTeam : Form
    {
        public EditTeam(Team team)
        {
            InitializeComponent();
            txt_department.Text = team.departement;
            txt_email.Text = team.email;
            txt_Name.Text = team.name;
            txt_password.Text = team.password;
            cmb_role.SelectedItem = team.role;
            cmb_type.SelectedItem = team.type;
            if (team.status == true)
                chk_status.Checked = true;
            else
                chk_status.Checked = false;
            if (team.picture != null)
                pictureBox_team.Image = ConvertByteArrayToImage(team.picture);
            lbl_id.Text = team.id.ToString();

        }
        string imgLocation = "";

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            // team.id = int.Parse(lbl_id.Text);
            team.name = txt_Name.Text;
            team.email = txt_email.Text;
            // team.
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
