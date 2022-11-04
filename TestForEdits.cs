using Hil5_CRM_Project.DialogBox;
using Hil5_CRM_Project.Edit;
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

namespace Hil5_CRM_Project
{
    public partial class TestForEdits : Form
    {
        public TestForEdits()
        {
            InitializeComponent();
        }

        private void btnEditOrg_Click(object sender, EventArgs e)
        {
            Organization org = new Organization();
            int id = int.Parse(txtIdOrg.Text);
            DbAccess dbaccess = new DbAccess();
            //.SearchOrganization(id);
            //dbaccess.UpdateOrganization();
           org = dbaccess.SearchOrganization(id);
            EditOrganization editOrg = new EditOrganization(org);

            editOrg.Show();
        }

        private void btn_editCustomer_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            int id = int.Parse(txtIdCustomer.Text);
            DbAccess dbaccess = new DbAccess();
            cust = dbaccess.SearchCustomers(id);

            EditCustomers editCust = new EditCustomers(cust);
            
            editCust.Show();
        }

        private void btn_editTask_Click(object sender, EventArgs e)
        {
            Hil5_CRM_Project.model.Task task = new Hil5_CRM_Project.model.Task();
            int id = int.Parse(txt_IdTask.Text);
            DbAccess dbaccess = new DbAccess();
            task = dbaccess.SearchTasks(id);

            EditTask editTask = new EditTask(task);
            editTask.Show();

        }
    }
}
