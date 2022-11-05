using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hil5_CRM_Project.model;

namespace Hil5_CRM_Project.DialogBox
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
            lbl_required1.Hide();
            lbl_required2.Hide();
            lbl_required3.Hide();
            lbl_required4.Hide();
            lbl_required5.Hide();
            lbl_required6.Hide();

            txt_name.Text = null;
            txt_referName.Text = null;
            txt_referName.Text = null;
            List<int> idList = new List<int>() { 1, 2, 3 };
            cmb_addedBy.DataSource = idList;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           Hil5_CRM_Project.model.Task task = new Hil5_CRM_Project.model.Task(); 
            //Validation
            
            //Name
            if (!String.IsNullOrEmpty(txt_name.Text))
            {
                task.name = txt_name.Text;
            }
            else
            {
                lbl_required1.Show();
            }

            //status
            if (cmb_status.SelectedItem == null)
            {
                cmb_status.BorderThickness = 2;
                cmb_status.BorderColor = Color.Red;
                lbl_required3.Show();

            }
            else
            {
                task.status = cmb_status.SelectedItem.ToString();
            }

            //refer type
            if (cmb_referType.SelectedItem == null)
            {
                cmb_referType.BorderThickness = 2;
                cmb_referType.BorderColor = Color.Red;
                lbl_required4.Show();

            }
            else
            {
                task.referType = cmb_referType.SelectedItem.ToString();
            }

            //refer name validation
            //Refer Name
            if (!String.IsNullOrEmpty(txt_referName.Text))
            {
                task.referName = txt_referName.Text;
            }
            else
            {
                lbl_required5.Show();
            }

            //note
            task.note = null;
            if (txt_Note.Text !=null)
            {
                task.note = txt_Note.Text;
            }
            else
            {
                task.note = null;
            }
           //no validation for now

            //priorty
            if (cmb_priority.SelectedItem == null)
            {
                cmb_priority.BorderThickness = 2;
                cmb_priority.BorderColor = Color.Red;
                lbl_required6.Show();

            }
            else
            {
                task.priority = cmb_priority.SelectedItem.ToString();
            }
            //AddedBy
           if (cmb_addedBy.SelectedItem == null)
            {
                cmb_addedBy.BorderThickness = 2;
                cmb_addedBy.BorderColor = Color.Red;
                lbl_required2.Show();

            }
            else
            {
                task.addedBy = Int32.Parse(cmb_addedBy.SelectedItem.ToString());

            }

            DbAccess dbaccess = new DbAccess();
            dbaccess.AddTask(task);
            this.Close();

        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_referName.Focus();
            }
        }
    }
}
