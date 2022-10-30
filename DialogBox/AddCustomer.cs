﻿using System;
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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            lbl_required1.Hide();
            lbl_required2.Hide();
            lbl_required3.Hide();
            lbl_required4.Hide();
            lbl_required5.Hide();
            lbl_required6.Hide();
            lbl_required7.Hide();
            txt_email.Text = null;
            txt_phone.Text = null;
            txt_WebUrl.Text = null;
            List<int> idListOfTeam = new List<int>() { 1, 2, 3 };
            cmb_addedby.DataSource = idListOfTeam;

            dtp_addedDate.MinDate = DateTime.Now;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)| *.jpg | PNG files(.*png) | *.png | All Files(*.*) | *.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                    pictureBox_customer.ImageLocation = imgLocation;

                }
            }
            catch (Exception)
            {
                msg_dialogError.Show("An error has occured");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();

            customer.addedDate = dtp_addedDate.Value;

            //Validation

            /*
             // Commented the regex validation of name for a moment
            //Name
            if (String.IsNullOrEmpty(txt_Name.Text))
                lbl_required1.Show();
            Regex rName = new Regex(@"^[A-Z a-z]{3,30}$");
            if (rName.IsMatch(txt_Name.Text))
            {
                customer.name = txt_Name.Text;
                //MessageBox.Show("Test");
            }
            else
            {
                txt_Name.BorderColor = Color.Red;
                txt_Name.BorderThickness = 1;
                txt_Name.Text = "";
                txt_Name.PlaceholderText = "first last";
            }
            */

            customer.name = txt_Name.Text;

            //Email
            if (String.IsNullOrEmpty(txt_email.Text))
                lbl_required2.Show();
            Regex rEmail = new Regex(@"^[^@\s]+@[^@\s\.]+\.[^@\.\s]+$");
            if (rEmail.IsMatch(txt_email.Text))
            {
                customer.email = txt_email.Text;
                //MessageBox.Show("Test");
            }
            else
            {
                txt_email.BorderColor = Color.Red;
                txt_email.BorderThickness = 2;
                txt_email.Text = "";
                txt_email.PlaceholderText = "ex: abc1@gmail.com";
            }

            //Phone
            if (String.IsNullOrEmpty(txt_phone.Text))
                lbl_required3.Show();
            Regex rPhone = new Regex(@"^[0-9]*$");
            int len = txt_phone.Text.Length;
            if (rPhone.IsMatch(txt_phone.Text))
            {
                if (len == 9)
                {
                    string phone = "+251" + txt_phone.Text;
                    customer.mobile = phone;
                    MessageBox.Show(phone);
                }
                else
                {
                    msg_dialogError.Show("The length of the phone is not valid.");
                    txt_phone.Text = "";
                }
            }
            else
            {
                txt_phone.BorderColor = Color.Red;
                txt_phone.BorderThickness = 2;
                msg_dialogError.Show("Only numbers are allowed");
                txt_phone.Text = "";
            }

            //City
            if (!String.IsNullOrEmpty(txt_city.Text))
            {
                customer.city = txt_city.Text;
            }
            else
            {
                lbl_required4.Show();
            }


            //Zip
            if (string.IsNullOrEmpty(txt_zip.Text))
            {
                lbl_required5.Show();
            }
            Regex rZip = new Regex(@"^\d{5,}$");
            if (rZip.IsMatch(txt_zip.Text))
            {
                customer.zip = txt_zip.Text;
            }
            else
            {
                txt_zip.BorderColor = Color.Red;
                txt_zip.BorderThickness = 2;
                txt_zip.Text = "";
                txt_zip.PlaceholderText = "minimum 5 digits";
            }


            //country
            if (!String.IsNullOrEmpty(txt_country.Text))
            {
                customer.country = txt_country.Text;
            }
            else
            {
                lbl_required6.Show();
            }

            //Website
            Regex rUrl = new Regex("^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");

            if (!string.IsNullOrEmpty(txt_WebUrl.Text))
            {
                if (!rUrl.IsMatch(txt_WebUrl.Text))
                {
                    msg_dialogError.Show("The website URL you have provided is invalid" + "\n" + "you can leave this field empty");
                    txt_WebUrl.Text = null;
                }
                else
                {
                    customer.website = txt_WebUrl.Text;

                }
            }
            else
            {
                customer.website = null;
            }

            //Added By

            customer.addedBy = int.Parse(cmb_addedby.SelectedValue.ToString());


            // saving customer to database.
            DbAccess dbAccess = new DbAccess();
            dbAccess.AddCustomer(customer);
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
                txt_phone.Focus();
            }
        }

        private void txt_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_city.Focus();
            }
        }

        private void txt_city_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_zip.Focus();
            }
        }

        private void txt_zip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_country.Focus();
            }
        }

        private void txt_country_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_WebUrl.Focus();
            }
        }
    }
}