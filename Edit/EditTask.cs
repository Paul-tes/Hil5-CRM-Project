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

namespace Hil5_CRM_Project.Edit
{
    public partial class EditTask : Form
    {
        //
        public EditTask(Hil5_CRM_Project.model.Task task)
        {
            InitializeComponent();
            txt_name.Text = task.name;
            if (task.note != null)
            txt_Note.Text = task.note;
            txt_referName.Text = task.referName;
            lbl_id.Text = task.id.ToString();
            List<int> idListOfTeam = new List<int>() { 1, 2, 3 };
            cmb_addedBy.DataSource = idListOfTeam;


            cmb_priority.SelectedItem = task.priority;
            cmb_referType.SelectedItem = task.referType;
            cmb_status.SelectedItem = task.status;
            //  MessageBox.Show(task.priority);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //cmb_priority.SelectedValue = cmb_priority.SelectedIndex;
            Hil5_CRM_Project.model.Task task = new Hil5_CRM_Project.model.Task();
          
            task.id = int.Parse(lbl_id.Text);
            task.name = txt_name.Text;
            task.referName = txt_referName.Text;
            task.referType = cmb_referType.SelectedItem.ToString();

            task.addedBy = int.Parse(cmb_addedBy.SelectedValue.ToString());
            if (cmb_priority.SelectedItem != null)
            task.priority = cmb_priority.SelectedItem.ToString();
            task.status = cmb_status.SelectedItem.ToString();  
            if (txt_Note.Text != null)
            {
                task.note = txt_Note.Text;  
            }



            DbAccess dbaccess = new DbAccess();
            dbaccess.UpdateTask(task);
        }

        
    }
}
