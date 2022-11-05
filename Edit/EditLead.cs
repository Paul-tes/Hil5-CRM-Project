using Hil5_CRM_Project.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hil5_CRM_Project.Edit
{
    public partial class EditLead : Form
    {
        public EditLead(Leads lead)
        {
            InitializeComponent();
            txt_email.Text = lead.email;
            txt_name.Text = lead.name;
            if (lead.note != null)
                txt_note.Text = lead.note;
            List<int> idListOfTeam = new List<int>() { 1, 2, 3 };
            cmb_addedBy.DataSource = idListOfTeam;
            cmb_addedBy.SelectedItem = lead.addedBy;
            cmb_source.SelectedItem = lead.source;
            cmb_status.SelectedItem = lead.status;
            lbl_id.Text = lead.id.ToString();
            lead.createDate = dtp_addedDate.Value;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Leads lead = new Leads();
            lead.id = int.Parse(lbl_id.Text);
            lead.name = txt_name.Text;
            lead.email = txt_email.Text;
            lead.addedBy = int.Parse(cmb_addedBy.SelectedItem.ToString());
            lead.status = cmb_status.SelectedItem.ToString();
            lead.source = cmb_source.SelectedItem.ToString();
            lead.createDate = dtp_addedDate.Value;
            lead.note = txt_note.Text;
            DbAccess dbaccess = new DbAccess();

            dbaccess.UpdateLead(lead);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
