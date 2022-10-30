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
            List<int> idListOfTeam = new List<int>() { 1, 2, 3 };
             cmb_addedBy.DataSource = idListOfTeam;
            

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Leads lead = new Leads();
            lead.createDate = DateTime.Now;
            lead.note = txt_note.Text;
            //Validation
            //Name
            if (String.IsNullOrEmpty(txt_name.Text))
                lbl_required1.Show();
            Regex rName = new Regex(@"^[A-Z a-z]{3,30}$");
            if (rName.IsMatch(txt_name.Text))
            {
                lead.name = txt_name.Text;
                //MessageBox.Show("Test");
            }
            else
            {
                lead.name = "abebe";
            }

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
                cmb_source.BorderThickness = 2;
                cmb_source.BorderColor = Color.Red;
                lbl_required5.Show();
            }
            else 
            {
                lead.addedBy = int.Parse(cmb_addedBy.SelectedItem.ToString()); 
            }

            //note
            if (txt_note.Text != null)
            {
                lead.note = txt_note.Text;
            }
            DbAccess dbaccess = new DbAccess();
            dbaccess.AddLead(lead);


            //added date
            lead.createDate = DateTime.Parse(dtp_addedDate.Text.ToString());


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
