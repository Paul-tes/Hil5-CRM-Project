using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hil5_CRM_Project.model;

namespace Hil5_CRM_Project.DialogBox
{
    public partial class AddOrganization : Form
    {
        public AddOrganization()
        {
            InitializeComponent();
            lbl_required1.Hide();
            lbl_required2.Hide();
            lbl_required3.Hide();
            lbl_required4.Hide();
            txt_email.Text = null;
            txt_phone.Text = null;
            txt_name.Text = null;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Organization organization = new Organization();

            //Validation
            //Name
            if (!String.IsNullOrEmpty(txt_name.Text))
            {
                organization.name = txt_name.Text;
            }
            else
            {
                lbl_required1.Show();
            }

            //Email
            Regex rEmail = new Regex(@"^[^@\s]+@[^@\s\.]+\.[^@\.\s]+$");
            if (rEmail.IsMatch(txt_email.Text))
            {
                organization.email = txt_email.Text;
            }
            else
            {
                txt_email.BorderColor = Color.Red;
                txt_email.BorderThickness = 2;
                txt_email.Text = "";
                txt_email.PlaceholderText = "ex: abc1@gmail.com";
            }
            if (String.IsNullOrEmpty(txt_email.Text))
                lbl_required2.Show();

            //Phone
            Regex rPhone = new Regex(@"^[0-9]*$");
            if (rPhone.IsMatch(txt_phone.Text))
            {
                string phone = "+251" + txt_phone.Text;
                organization.phone = phone;
            }
            else
            {
                txt_phone.BorderColor = Color.Red;
                txt_phone.BorderThickness = 2;
                msg_dialogError.Show("Only numbers are allowed");
            }
            if (String.IsNullOrEmpty(txt_phone.Text))
                lbl_required3.Show();

            //Address
            if (!String.IsNullOrEmpty(txt_address.Text))
            {
                organization.addres = txt_address.Text;
            }
            else
            {
                lbl_required4.Show();
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_attach_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)| *.jpg | PNG files(.*png) | *.png | All Files(*.*) | *.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                    pictureBox_Logo.ImageLocation = imgLocation;

                }
            }
            catch (Exception)
            {
                msg_dialogError.Show("An error has occured");
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_phone.Focus();
            }
        }

        private void txt_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_address.Focus();
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_email.Focus();
            }
        }


    }
}
