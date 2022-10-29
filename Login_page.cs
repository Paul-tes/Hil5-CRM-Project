using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hil5_CRM_Project
{
    public partial class Login_page : Form
    {

        public Login_page()
        {
            InitializeComponent();
        }

        
       

        private void lbl_forgot_Click(object sender, EventArgs e)
        {

        }

        private void txt_pswd_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                txt_pswd.Text = "";
                txt_email.Text = "";
            }
        }

        private void cb_exit_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (cb_admin.Checked)
           {

               try
               {
                   //public static string admin = ConfigurationManager.ConnectionStrings["teamAdmin"].ConnectionString;
                   // string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
                   //string connectionString = string.Format("Data Source={0};Initial Catalog=;User ID={2};Password={3};", "DESKTOP-V03ADMS", ""CRM_PROJECT", , txtPassword.Text);
                   //connectionString = "server =.; Database = CRM_PROJECT;Integrated security = false; uid = TeamAdmin Login; pwd = 0;"
                   string connectionString = String.Format("server ={0}; Database = {1};Integrated security = {2}; uid = {3}; pwd = {4};", "DESKTOP-V03ADMS", "CRM_PROJECT", "false", "TeamAdmin Login", txt_pswd.Text);
                   SqlHelper sqlhelper = new SqlHelper(connectionString);
                    if(sqlhelper.isConnected())
                    {
                        this.Hide();
                        MdiMainForm mainForm = new MdiMainForm("Admin");
                        mainForm.ShowDialog();
                    }
                    

               }
               catch (SqlException ex)
               {
                   MessageBox.Show(ex.Message);
               }
           }else
           {
               try
               {
                   string connectionString = String.Format("server ={0}; Database = {1};Integrated security = {2}; uid = {3}; pwd = {4};", "DESKTOP-V03ADMS", "CRM_PROJECT", "false", "Team Login", txt_pswd.Text);
                   SqlHelper sqlhelper = new SqlHelper(connectionString);
                    if (sqlhelper.isConnected())
                    {
                        this.Hide();
                        MdiMainForm mainForm = new MdiMainForm("Team");
                        mainForm.ShowDialog();
                    }
                }
               catch (SqlException ex)
               {
                   MessageBox.Show(ex.Message);

               }
           }
            
        }

    }
}
