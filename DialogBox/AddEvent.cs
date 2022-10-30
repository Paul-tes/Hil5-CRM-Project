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
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
            lbl_required1.Hide();
            lbl_required2.Hide();
            lbl_required3.Hide();
            lbl_required4.Hide();
            lbl_required5.Hide();
            lbl_required6.Hide();
            lbl_required7.Hide();
            dtp_startDate.MinDate = DateTime.Now;
            dtp_endDate.MinDate = DateTime.Now;
            txt_topic.Text = null;

            //added by (team member id) // will get replaced with a stored procedure
            List<int> teamIds = new List<int>() { 1, 2, 3, 4, 5, 6 };
            cmb_addedBy.DataSource = teamIds.ToList();
            cmb_addedBy.SelectedItem = null;
            //added by (team member id) // will get replaced with a stored procedure
            List<int> guestIds = new List<int>() { 11, 22, 33, 44, 55, 66};
            cmb_guestsList.DataSource = guestIds.ToList();
            cmb_guestsList.SelectedItem = null;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Events events = new Events();

          
            //Topic
            if(txt_topic.Text.Length > 30)
            {
                txt_topic.BorderColor = Color.Red;
                txt_topic.BorderThickness = 2;
                txt_topic.Text = ""; 
                msg_dialogError.Show("You are not allowed to use more than thirty characters for topic");
              
            }
            else
            {

                if (string.IsNullOrEmpty(txt_topic.Text))
                {
                    //msg_dialogError.Show("Hello");
                    lbl_required1.Show();
                    txt_topic.BorderColor = Color.Red;
                    txt_topic.BorderThickness = 2;

                }
                else
                {
                    events.topic = txt_topic.Text;
                }
                
            }

            //Note
           if (cmb_note.SelectedItem == null)
            {
                cmb_note.BorderThickness = 2;
                cmb_note.BorderColor = Color.Red;
                lbl_required2.Show();

            }
            else
            {
                events.note = cmb_note.SelectedItem.ToString();
               // msg_dialogError.Show("ne..");
            }

            //type
            if (cmb_type.SelectedItem == null)
            {
                cmb_type.BorderThickness = 2;
                cmb_type.BorderColor = Color.Red;
                lbl_required3.Show();

            }
            else
            {
                events.type = cmb_type.SelectedItem.ToString();
                 
            }

            //added by
            if (cmb_addedBy.SelectedItem == null)
            {
                cmb_addedBy.BorderThickness = 2;
                cmb_addedBy.BorderColor = Color.Red;
                lbl_required4.Show();

            }
            else
            {
                events.addedBy = Int32.Parse(cmb_addedBy.SelectedItem.ToString());
               
            }


            //status
            if (cmb_Status.SelectedItem == null)
            {
                cmb_Status.BorderThickness = 2;
                cmb_Status.BorderColor = Color.Red;
                lbl_required5.Show();

            }
            else
            {
                events.status = cmb_Status.SelectedItem.ToString();
            }

            //guests
            if (cmb_guestsList.SelectedItem == null)
            {
                cmb_guestsList.BorderThickness = 2;
                cmb_guestsList.BorderColor = Color.Red;
                lbl_required6.Show();

            }
            else
            {
               // events.Gustid = Int32.Parse(cmb_guestsList.SelectedItem.ToString());
            }

            //start date
            events.startDate = dtp_startDate.Value;
            events.endDate = dtp_endDate.Value;

            if (events.startDate > events.endDate)
            msg_dialogError.Show("The start date can't be higher than the end date!");
            else if (events.startDate == events.endDate  && events.startTime >= events.endTime)
            msg_dialogError.Show("Check your time please!");

            DbAccess dbaccess = new DbAccess();
            dbaccess.AddEvent(events);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_topic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txt_department.Focus();
            }
        }
    }
}
