namespace Hil5_CRM_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.flp_leftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_dashBoard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Contacts = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_leads = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Events = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_tasks = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_reports = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.p_top = new System.Windows.Forms.Panel();
            this.flp_windowControl = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.timer_sideBar = new System.Windows.Forms.Timer(this.components);
            this.flp_leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.p_top.SuspendLayout();
            this.flp_windowControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_leftPanel
            // 
            this.flp_leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.flp_leftPanel.Controls.Add(this.panel1);
            this.flp_leftPanel.Controls.Add(this.panel2);
            this.flp_leftPanel.Controls.Add(this.panel4);
            this.flp_leftPanel.Controls.Add(this.panel5);
            this.flp_leftPanel.Controls.Add(this.panel6);
            this.flp_leftPanel.Controls.Add(this.panel7);
            this.flp_leftPanel.Controls.Add(this.panel8);
            this.flp_leftPanel.Controls.Add(this.panel9);
            this.flp_leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_leftPanel.Location = new System.Drawing.Point(0, 0);
            this.flp_leftPanel.MaximumSize = new System.Drawing.Size(192, 780);
            this.flp_leftPanel.MinimumSize = new System.Drawing.Size(60, 780);
            this.flp_leftPanel.Name = "flp_leftPanel";
            this.flp_leftPanel.Size = new System.Drawing.Size(60, 780);
            this.flp_leftPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 167);
            this.panel1.TabIndex = 0;
            // 
            // btn_menu
            // 
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = global::Hil5_CRM_Project.Properties.Resources._menu;
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(-8, 109);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu.Size = new System.Drawing.Size(225, 55);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = "                Menu";
            this.btn_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 60);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_dashBoard);
            this.panel2.Location = new System.Drawing.Point(3, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 43);
            this.panel2.TabIndex = 1;
            // 
            // btn_dashBoard
            // 
            this.btn_dashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashBoard.ForeColor = System.Drawing.Color.White;
            this.btn_dashBoard.Image = global::Hil5_CRM_Project.Properties.Resources._dashboard;
            this.btn_dashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashBoard.Location = new System.Drawing.Point(-6, -8);
            this.btn_dashBoard.Name = "btn_dashBoard";
            this.btn_dashBoard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_dashBoard.Size = new System.Drawing.Size(225, 62);
            this.btn_dashBoard.TabIndex = 1;
            this.btn_dashBoard.Text = "                DashBoard";
            this.btn_dashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashBoard.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Contacts);
            this.panel4.Location = new System.Drawing.Point(3, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 43);
            this.panel4.TabIndex = 1;
            // 
            // btn_Contacts
            // 
            this.btn_Contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contacts.ForeColor = System.Drawing.Color.White;
            this.btn_Contacts.Image = global::Hil5_CRM_Project.Properties.Resources._contacts;
            this.btn_Contacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Contacts.Location = new System.Drawing.Point(-6, -8);
            this.btn_Contacts.Name = "btn_Contacts";
            this.btn_Contacts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Contacts.Size = new System.Drawing.Size(225, 62);
            this.btn_Contacts.TabIndex = 1;
            this.btn_Contacts.Text = "                Contacts";
            this.btn_Contacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Contacts.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_leads);
            this.panel5.Location = new System.Drawing.Point(3, 274);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 43);
            this.panel5.TabIndex = 1;
            // 
            // btn_leads
            // 
            this.btn_leads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leads.ForeColor = System.Drawing.Color.White;
            this.btn_leads.Image = global::Hil5_CRM_Project.Properties.Resources._leads;
            this.btn_leads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_leads.Location = new System.Drawing.Point(-6, -8);
            this.btn_leads.Name = "btn_leads";
            this.btn_leads.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_leads.Size = new System.Drawing.Size(225, 62);
            this.btn_leads.TabIndex = 1;
            this.btn_leads.Text = "                Leads";
            this.btn_leads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_leads.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Events);
            this.panel6.Location = new System.Drawing.Point(3, 323);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 43);
            this.panel6.TabIndex = 1;
            // 
            // btn_Events
            // 
            this.btn_Events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Events.ForeColor = System.Drawing.Color.White;
            this.btn_Events.Image = global::Hil5_CRM_Project.Properties.Resources._events;
            this.btn_Events.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Events.Location = new System.Drawing.Point(-6, -8);
            this.btn_Events.Name = "btn_Events";
            this.btn_Events.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Events.Size = new System.Drawing.Size(225, 62);
            this.btn_Events.TabIndex = 1;
            this.btn_Events.Text = "                Events";
            this.btn_Events.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Events.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_tasks);
            this.panel7.Location = new System.Drawing.Point(3, 372);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 43);
            this.panel7.TabIndex = 1;
            // 
            // btn_tasks
            // 
            this.btn_tasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tasks.ForeColor = System.Drawing.Color.White;
            this.btn_tasks.Image = global::Hil5_CRM_Project.Properties.Resources._tasks;
            this.btn_tasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tasks.Location = new System.Drawing.Point(-6, -8);
            this.btn_tasks.Name = "btn_tasks";
            this.btn_tasks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tasks.Size = new System.Drawing.Size(225, 62);
            this.btn_tasks.TabIndex = 1;
            this.btn_tasks.Text = "                Tasks";
            this.btn_tasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tasks.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_reports);
            this.panel8.Location = new System.Drawing.Point(3, 421);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 43);
            this.panel8.TabIndex = 1;
            // 
            // btn_reports
            // 
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.White;
            this.btn_reports.Image = global::Hil5_CRM_Project.Properties.Resources._reports;
            this.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.Location = new System.Drawing.Point(-6, -8);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_reports.Size = new System.Drawing.Size(225, 62);
            this.btn_reports.TabIndex = 1;
            this.btn_reports.Text = "                Reports";
            this.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_settings);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(3, 470);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(197, 43);
            this.panel9.TabIndex = 1;
            // 
            // btn_settings
            // 
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = global::Hil5_CRM_Project.Properties.Resources._settings;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(-6, -8);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_settings.Size = new System.Drawing.Size(225, 62);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "                Settings";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.p_top.Controls.Add(this.flp_windowControl);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.Location = new System.Drawing.Point(60, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(1200, 34);
            this.p_top.TabIndex = 1;
            // 
            // flp_windowControl
            // 
            this.flp_windowControl.Controls.Add(this.btn_minimize);
            this.flp_windowControl.Controls.Add(this.btn_maximize);
            this.flp_windowControl.Controls.Add(this.btn_close);
            this.flp_windowControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.flp_windowControl.Location = new System.Drawing.Point(1077, 0);
            this.flp_windowControl.Name = "flp_windowControl";
            this.flp_windowControl.Size = new System.Drawing.Size(123, 34);
            this.flp_windowControl.TabIndex = 2;
            // 
            // btn_minimize
            // 
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = global::Hil5_CRM_Project.Properties.Resources.icons8_subtract_24;
            this.btn_minimize.Location = new System.Drawing.Point(3, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(31, 28);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.Image = global::Hil5_CRM_Project.Properties.Resources.icons8_maximize_window_50__2_;
            this.btn_maximize.Location = new System.Drawing.Point(40, 3);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(33, 28);
            this.btn_maximize.TabIndex = 1;
            this.btn_maximize.UseVisualStyleBackColor = true;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Hil5_CRM_Project.Properties.Resources.icons8_close_window_50;
            this.btn_close.Location = new System.Drawing.Point(79, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 27);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // timer_sideBar
            // 
            this.timer_sideBar.Interval = 10;
            this.timer_sideBar.Tick += new System.EventHandler(this.timer_sideBar_Tick_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1260, 562);
            this.Controls.Add(this.p_top);
            this.Controls.Add(this.flp_leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Hil5-CRM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flp_leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.p_top.ResumeLayout(false);
            this.flp_windowControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.FlowLayoutPanel flp_leftPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_dashBoard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Contacts;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_leads;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Events;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_tasks;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.FlowLayoutPanel flp_windowControl;
        private System.Windows.Forms.Timer timer_sideBar;
    }
}

