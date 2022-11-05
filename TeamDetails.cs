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
    public partial class TeamDetails : Form
    {
        public TeamDetails(Team tm)
        {
            InitializeComponent();
            txt_Name.Text = tm.name;
            txt_gender.Text = tm.gender;
            txt_email.Text = tm.email;
            txt_department.Text = tm.departement;
            txt_role.Text = tm.role;
            if (tm.status == true)
                txt_status.Text = "Active";
            else
                txt_status.Text = "Not Active";
            txt_type.Text = tm.type;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
