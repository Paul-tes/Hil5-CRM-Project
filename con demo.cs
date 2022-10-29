using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Hil5_CRM_Project
{
    public partial class con_demo : Form
    {
        public static string win = ConfigurationManager.ConnectionStrings["win"].ConnectionString;
        public static string admin = ConfigurationManager.ConnectionStrings["teamAdmin"].ConnectionString;
        public static string team = ConfigurationManager.ConnectionStrings["team"].ConnectionString;
        SqlConnection con = new SqlConnection(team);

        public con_demo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
         
                con.Open();
                MessageBox.Show("Connection is successful !");
                //conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
