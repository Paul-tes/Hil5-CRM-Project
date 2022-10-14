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
    public partial class MdiMainForm : Form
    {
        private bool sidebarExpand = false;
        private Button _currentBtn;
        private Button _previousBtn;
        private Form _activeForm;
        // constructor
        public MdiMainForm()
        {
            InitializeComponent();
        }
        //child Form Control.
        private void OpenChildform(Form childForm, object btnSender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            ActiveButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // changing interface the current button.
        private  void ActiveButton (object btnSender)
        {
            // reverse the previous button in to the previous status.
            DisableButton();
            _previousBtn = (Button)btnSender;
            if (btnSender != null) 
            { 
                if (_currentBtn != (Button)btnSender)
                {
                    _currentBtn = (Button)btnSender;
                    _currentBtn.BackColor = Color.FromArgb(59, 59, 59);
                    _currentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        // Disable Button btn interface change.
        private void DisableButton()
        {
            if (_previousBtn != null)
            {
                _previousBtn.BackColor = Color.FromArgb(20, 26, 26);
                _previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
            
        private void btn_menu_Click(object sender, EventArgs e)
        {
            timer_sideBar.Start();
            
        }

        private void timer_sideBar_Tick(object sender, EventArgs e)
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
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_dashBoard_Click(object sender, EventArgs e)
        {
            OpenChildform(new DashBoardForm(), sender);
        }

        private void btn_Contacts_Click(object sender, EventArgs e)
        {
            OpenChildform(new CustomersForm(), sender);

        }

        private void btn_leads_Click(object sender, EventArgs e)
        {
            OpenChildform(new LeadsForm(), sender);
        }

        private void btn_Events_Click(object sender, EventArgs e)
        {
            OpenChildform(new EventForm(), sender);
        }

        private void btn_tasks_Click(object sender, EventArgs e)
        {
            OpenChildform(new TaskForm(), sender);
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            OpenChildform(new ReportForm(), sender);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            OpenChildform(new TaskForm(), sender);
        }
    }
}
