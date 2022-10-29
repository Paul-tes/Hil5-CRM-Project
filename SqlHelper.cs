using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Hil5_CRM_Project
{
    internal class SqlHelper
    {
        public static string win = ConfigurationManager.ConnectionStrings["win"].ConnectionString;
        public static string admin = ConfigurationManager.ConnectionStrings["teamAdmin"].ConnectionString;
        public static string team = ConfigurationManager.ConnectionStrings["team"].ConnectionString;


        SqlConnection con = new SqlConnection(admin);
        public SqlHelper(string connectionString)
        {

            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Connected!");

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool isConnected()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public void close()
        {
            con.Close();
        }
        public SqlConnection connection()
        {
            return con;
        }



        /* public bool IsConnection
         {
             get
             {
                 //if (cn.State == System.Data.ConnectionState.Closed)
                     cn.Open();
                 if (cn.State == System.Data.ConnectionState.Open)
                 {
                     MessageBox.Show("connected.");
                 }
                 return true;
             }
         }
        */
    }
       
    
}
