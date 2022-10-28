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
    public partial class AddLead : Form
    {
        public AddLead()
        {
            InitializeComponent();
            lbl_required1.Hide();
            lbl_required2.Hide();
            lbl_required3.Hide();
            lbl_required4.Hide();
            lbl_required5.Hide();
            dtp_addedDate.MinDate = DateTime.Now;
            txt_email.Text = null;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Leads lead = new Leads();
            lead.createDate = DateTime.Now;

            //Validation


            //Email
            if (String.IsNullOrEmpty(txt_email.Text))
                lbl_required2.Show();
            Regex rEmail = new Regex(@"^[^@\s]+@[^@\s\.]+\.[^@\.\s]+$");
            if (rEmail.IsMatch(txt_email.Text))
            {
                lead.email = txt_email.Text;
            }
            else
            {
                txt_email.BorderColor = Color.Red;
                txt_email.BorderThickness = 2;
                txt_email.Text = "";
                txt_email.PlaceholderText = "ex: abc1@gmail.com";
            }


            //Status
            if (cmb_status.SelectedItem == null)
            {
                cmb_status.BorderThickness = 2;
                cmb_status.BorderColor = Color.Red;
                lbl_required4.Show();

            }
            else
            {
                lead.status = cmb_status.SelectedItem.ToString();
     
            }

            //Source
            if (cmb_source.SelectedItem == null)
            {
                cmb_source.BorderThickness = 2;
                cmb_source.BorderColor = Color.Red;
                lbl_required3.Show();

            }
            else
            {
                lead.source = cmb_source.SelectedItem.ToString();
            
            }

            //Added By
            if (cmb_addedBy.SelectedItem == null)
            {
                cmb_addedBy.BorderThickness = 2;
                cmb_addedBy.BorderColor = Color.Red;
                lbl_required5.Show();

            }
            else
            {
                lead.addedBy = cmb_addedBy.SelectedItem.ToString();
      
            }

            //added date
            lead.createDate = DateTime.Parse(dtp_addedDate.ToString());


        }

  

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
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
                txt_note.Focus();
            }
        }

     

     
    }
}
