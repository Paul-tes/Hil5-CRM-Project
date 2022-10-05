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
    public partial class MainForm : Form
    {
        private bool sidebarExpand = false;
        public MainForm()
        {
            InitializeComponent();
        }
        // Window control close button.
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Window control minimiz button.
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Window control maximizing button.
        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            } else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // Timer for Minimizing and Maximizing side bar.
        private void btn_menu_Click(object sender, EventArgs e)
        {
            timer_sideBar.Start();
        }

        private void timer_sideBar_Tick_1(object sender, EventArgs e)
        {

            if (sidebarExpand) // minimizing the left side bar. 
            {
                flp_leftPanel.Width -= 10;
                if (flp_leftPanel.Width == flp_leftPanel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer_sideBar.Stop();
                }
            }
            else // expanding the left side bar.
            {
                flp_leftPanel.Width += 10;
                if (flp_leftPanel.Width == flp_leftPanel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer_sideBar.Stop();
                }
            }
        }
    }
}
