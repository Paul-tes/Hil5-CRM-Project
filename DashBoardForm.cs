using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hil5_CRM_Project.DialogBox;
namespace Hil5_CRM_Project
{
    public partial class DashBoardForm : Form
    {
        string con = "";
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(id) FROM customers;", sqlhelper.connection());
                lb_NoCustomers.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand("SELECT COUNT(id) FROM leads;", sqlhelper.connection());
                lb_NoLeads.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand("SELECT COUNT(id) FROM events;", sqlhelper.connection());
                lb_NoEvents.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand("SELECT COUNT(id) FROM tasks;", sqlhelper.connection());
                lb_NoTasks.Text = cmd.ExecuteScalar().ToString();
            }
            sqlhelper.close();
        }

        private void btn_addTeam_Click(object sender, EventArgs e)
        {
            DialogBox.AddTeam addTeam = new DialogBox.AddTeam();
            addTeam.ShowDialog();
        }

        private void btn_showTeam_Click(object sender, EventArgs e)
        {
            // Team custom car operations.
        }
    }
}
