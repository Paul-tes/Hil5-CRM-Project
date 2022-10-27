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
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }


        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_admin_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
