using System;
using System.Windows.Forms;
using Hil5_CRM_Project.DialogBox;
namespace Hil5_CRM_Project
{
    public partial class LeadsForm : Form
    {
        public LeadsForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddLead addlead = new AddLead();
            addlead.ShowDialog();
            addlead.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
