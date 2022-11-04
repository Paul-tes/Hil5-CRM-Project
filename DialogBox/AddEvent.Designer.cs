namespace Hil5_CRM_Project.DialogBox
{
    partial class AddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent));
            this.panel_drag = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbl_Title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dtp_endDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_startDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_required4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_required7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_required6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_required5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_required3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_required2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_required1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmb_note = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_guestsList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_Status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_addedBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_guests = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_AddedBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_type = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_gender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_topic = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_endDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_startDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_Topic = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.msg_dialogError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_drag.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_drag
            // 
            this.panel_drag.BackColor = System.Drawing.Color.Gold;
            this.panel_drag.Controls.Add(this.btn_exit);
            this.panel_drag.Controls.Add(this.lbl_Title);
            this.panel_drag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_drag.Location = new System.Drawing.Point(0, 0);
            this.panel_drag.Name = "panel_drag";
            this.panel_drag.Size = new System.Drawing.Size(666, 88);
            this.panel_drag.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.color = System.Drawing.Color.Transparent;
            this.btn_exit.colorActive = System.Drawing.Color.Red;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Image = null;
            this.btn_exit.ImagePosition = 20;
            this.btn_exit.ImageZoom = 50;
            this.btn_exit.LabelPosition = 35;
            this.btn_exit.LabelText = "X";
            this.btn_exit.Location = new System.Drawing.Point(597, 36);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(43, 46);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(56, 36);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(63, 26);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "EVENT";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dtp_endDate);
            this.bunifuGradientPanel1.Controls.Add(this.dtp_startDate);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required4);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required7);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required6);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required5);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required3);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required2);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required1);
            this.bunifuGradientPanel1.Controls.Add(this.btn_save);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_note);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_guestsList);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_Status);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_type);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_addedBy);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_guests);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_status);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_AddedBy);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_type);
            this.bunifuGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_gender);
            this.bunifuGradientPanel1.Controls.Add(this.txt_topic);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_endDate);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_startDate);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_Topic);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowFrame;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.WindowFrame;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 88);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(666, 464);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Checked = true;
            this.dtp_endDate.CustomFormat = "\"MM/dd/yyyy hh:mm:ss\"";
            this.dtp_endDate.FillColor = System.Drawing.Color.Gold;
            this.dtp_endDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_endDate.Location = new System.Drawing.Point(364, 329);
            this.dtp_endDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_endDate.MinDate = new System.DateTime(2022, 10, 14, 0, 0, 0, 0);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(234, 37);
            this.dtp_endDate.TabIndex = 11;
            this.dtp_endDate.Value = new System.DateTime(2022, 10, 14, 20, 35, 30, 406);
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Checked = true;
            this.dtp_startDate.CustomFormat = "\"MM/dd/yyyy hh:mm:ss\"";
            this.dtp_startDate.FillColor = System.Drawing.Color.Snow;
            this.dtp_startDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startDate.Location = new System.Drawing.Point(56, 329);
            this.dtp_startDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_startDate.MinDate = new System.DateTime(2022, 10, 21, 0, 0, 0, 0);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(234, 37);
            this.dtp_startDate.TabIndex = 11;
            this.dtp_startDate.Value = new System.DateTime(2022, 10, 21, 0, 0, 0, 0);
            // 
            // lbl_required4
            // 
            this.lbl_required4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_required4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_required4.ForeColor = System.Drawing.Color.Red;
            this.lbl_required4.Location = new System.Drawing.Point(181, 159);
            this.lbl_required4.Name = "lbl_required4";
            this.lbl_required4.Size = new System.Drawing.Size(13, 24);
            this.lbl_required4.TabIndex = 10;
            this.lbl_required4.Text = "*";
            // 
            // lbl_required7
            // 
            this.lbl_required7.BackColor = System.Drawing.Color.Transparent;
            this.lbl_required7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_required7.ForeColor = System.Drawing.Color.Red;
            this.lbl_required7.Location = new System.Drawing.Point(445, 285);
            this.lbl_required7.Name = "lbl_required7";
            this.lbl_required7.Size = new System.Drawing.Size(13, 24);
            this.lbl_required7.TabIndex = 10;
            this.lbl_required7.Text = "*";
            // 
            // lbl_required6
            // 
            this.lbl_required6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_required6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_required6.ForeColor = System.Drawing.Color.Red;
            this.lbl_required6.Location = new System.Drawing.Point(155, 242);
            this.lbl_required6.Name = "lbl_required6";
            this.lbl_required6.Size = new System.Drawing.Size(13, 24);
            this.lbl_required6.TabIndex = 10;
            this.lbl_required6.Text = "*";
            // 
            // lbl_required5
            // 
            this.lbl_required5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_required5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_required5.ForeColor = System.Drawing.Color.Red;
            this.lbl_required5.Location = new System.Drawing.Point(150, 203);
            this.lbl_required5.Name = "lbl_required5";
            this.lbl_required5.Size = new System.Drawing.Size(13, 24);
            this.lbl_required5.TabIndex = 10;
            this.lbl_required5.Text = "*";
            // 
            // lbl_required3
            // 
            this.lbl_required3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_required3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_required3.ForeColor = System.Drawing.Color.Red;
            this.lbl_required3.Location = new System.Drawing.Point(139, 122);
            this.lbl_required3.Name = "lbl_required3";
            this.lbl_required3.Size = new System.Drawing.Size(13, 24);
            this.lbl_required3.TabIndex = 10;
            this.lbl_required3.Text = "*";
            // 
            // lbl_required2
            // 
            this.lbl_required2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_required2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_required2.ForeColor = System.Drawing.Color.Red;
            this.lbl_required2.Location = new System.Drawing.Point(142, 78);
            this.lbl_required2.Name = "lbl_required2";
            this.lbl_required2.Size = new System.Drawing.Size(13, 24);
            this.lbl_required2.TabIndex = 10;
            this.lbl_required2.Text = "*";
            // 
            // lbl_required1
            // 
            this.lbl_required1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_required1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_required1.ForeColor = System.Drawing.Color.Red;
            this.lbl_required1.Location = new System.Drawing.Point(147, 40);
            this.lbl_required1.Name = "lbl_required1";
            this.lbl_required1.Size = new System.Drawing.Size(13, 24);
            this.lbl_required1.TabIndex = 10;
            this.lbl_required1.Text = "*";
            // 
            // btn_save
            // 
            this.btn_save.BorderColor = System.Drawing.Color.Teal;
            this.btn_save.BorderRadius = 20;
            this.btn_save.BorderThickness = 2;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_save.FillColor2 = System.Drawing.Color.Gray;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(384, 398);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 45);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "SAVE";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_note
            // 
            this.cmb_note.AutoRoundedCorners = true;
            this.cmb_note.BackColor = System.Drawing.Color.Transparent;
            this.cmb_note.BorderRadius = 17;
            this.cmb_note.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_note.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_note.FillColor = System.Drawing.Color.Moccasin;
            this.cmb_note.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_note.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_note.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_note.ItemHeight = 30;
            this.cmb_note.Items.AddRange(new object[] {
            "Planned",
            "Held",
            "Not Held",
            "Other"});
            this.cmb_note.Location = new System.Drawing.Point(214, 68);
            this.cmb_note.Name = "cmb_note";
            this.cmb_note.Size = new System.Drawing.Size(210, 36);
            this.cmb_note.TabIndex = 3;
            // 
            // cmb_guestsList
            // 
            this.cmb_guestsList.AutoRoundedCorners = true;
            this.cmb_guestsList.BackColor = System.Drawing.Color.Transparent;
            this.cmb_guestsList.BorderRadius = 17;
            this.cmb_guestsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_guestsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_guestsList.FillColor = System.Drawing.Color.Moccasin;
            this.cmb_guestsList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_guestsList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_guestsList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_guestsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_guestsList.ItemHeight = 30;
            this.cmb_guestsList.Location = new System.Drawing.Point(210, 231);
            this.cmb_guestsList.Name = "cmb_guestsList";
            this.cmb_guestsList.Size = new System.Drawing.Size(210, 36);
            this.cmb_guestsList.TabIndex = 3;
            // 
            // cmb_Status
            // 
            this.cmb_Status.AutoRoundedCorners = true;
            this.cmb_Status.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Status.BorderRadius = 17;
            this.cmb_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.FillColor = System.Drawing.Color.Moccasin;
            this.cmb_Status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Status.ItemHeight = 30;
            this.cmb_Status.Items.AddRange(new object[] {
            "New",
            "In Progress",
            "Finished"});
            this.cmb_Status.Location = new System.Drawing.Point(212, 191);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(210, 36);
            this.cmb_Status.TabIndex = 3;
            // 
            // cmb_type
            // 
            this.cmb_type.AutoRoundedCorners = true;
            this.cmb_type.BackColor = System.Drawing.Color.Transparent;
            this.cmb_type.BorderRadius = 17;
            this.cmb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FillColor = System.Drawing.Color.Moccasin;
            this.cmb_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_type.ItemHeight = 30;
            this.cmb_type.Items.AddRange(new object[] {
            "Call",
            "Conference",
            "Meeting",
            "Social",
            "Fundraising",
            "Other"});
            this.cmb_type.Location = new System.Drawing.Point(212, 109);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(210, 36);
            this.cmb_type.TabIndex = 3;
            // 
            // cmb_addedBy
            // 
            this.cmb_addedBy.AutoRoundedCorners = true;
            this.cmb_addedBy.BackColor = System.Drawing.Color.Transparent;
            this.cmb_addedBy.BorderRadius = 17;
            this.cmb_addedBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_addedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_addedBy.FillColor = System.Drawing.Color.Moccasin;
            this.cmb_addedBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_addedBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_addedBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_addedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_addedBy.ItemHeight = 30;
            this.cmb_addedBy.Location = new System.Drawing.Point(214, 150);
            this.cmb_addedBy.Name = "cmb_addedBy";
            this.cmb_addedBy.Size = new System.Drawing.Size(210, 36);
            this.cmb_addedBy.TabIndex = 3;
            // 
            // lbl_guests
            // 
            this.lbl_guests.BackColor = System.Drawing.Color.Transparent;
            this.lbl_guests.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guests.ForeColor = System.Drawing.Color.Gold;
            this.lbl_guests.Location = new System.Drawing.Point(98, 244);
            this.lbl_guests.Name = "lbl_guests";
            this.lbl_guests.Size = new System.Drawing.Size(56, 23);
            this.lbl_guests.TabIndex = 0;
            this.lbl_guests.Text = "Guests";
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Gold;
            this.lbl_status.Location = new System.Drawing.Point(100, 204);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(52, 23);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Status";
            // 
            // lbl_AddedBy
            // 
            this.lbl_AddedBy.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddedBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddedBy.ForeColor = System.Drawing.Color.Gold;
            this.lbl_AddedBy.Location = new System.Drawing.Point(100, 163);
            this.lbl_AddedBy.Name = "lbl_AddedBy";
            this.lbl_AddedBy.Size = new System.Drawing.Size(80, 23);
            this.lbl_AddedBy.TabIndex = 0;
            this.lbl_AddedBy.Text = "Added By";
            // 
            // lbl_type
            // 
            this.lbl_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_type.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.Gold;
            this.lbl_type.Location = new System.Drawing.Point(100, 122);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(40, 23);
            this.lbl_type.TabIndex = 0;
            this.lbl_type.Text = "Type";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gold;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(97, -117);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(42, 23);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Note";
            // 
            // lbl_gender
            // 
            this.lbl_gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ForeColor = System.Drawing.Color.Gold;
            this.lbl_gender.Location = new System.Drawing.Point(100, 82);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 23);
            this.lbl_gender.TabIndex = 0;
            this.lbl_gender.Text = "Note";
            // 
            // txt_topic
            // 
            this.txt_topic.BorderRadius = 11;
            this.txt_topic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_topic.DefaultText = "\r\n";
            this.txt_topic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_topic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_topic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_topic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_topic.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_topic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_topic.HoverState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_topic.Location = new System.Drawing.Point(214, 35);
            this.txt_topic.Name = "txt_topic";
            this.txt_topic.PasswordChar = '\0';
            this.txt_topic.PlaceholderText = "";
            this.txt_topic.SelectedText = "";
            this.txt_topic.Size = new System.Drawing.Size(210, 29);
            this.txt_topic.TabIndex = 1;
            this.txt_topic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_topic_KeyDown);
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_endDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endDate.ForeColor = System.Drawing.Color.Gold;
            this.lbl_endDate.Location = new System.Drawing.Point(364, 285);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(77, 23);
            this.lbl_endDate.TabIndex = 0;
            this.lbl_endDate.Text = "End Date";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_startDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startDate.ForeColor = System.Drawing.Color.Gold;
            this.lbl_startDate.Location = new System.Drawing.Point(56, 285);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(85, 23);
            this.lbl_startDate.TabIndex = 0;
            this.lbl_startDate.Text = "Start Date";
            // 
            // lbl_Topic
            // 
            this.lbl_Topic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Topic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Topic.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Topic.Location = new System.Drawing.Point(100, 41);
            this.lbl_Topic.Name = "lbl_Topic";
            this.lbl_Topic.Size = new System.Drawing.Size(45, 23);
            this.lbl_Topic.TabIndex = 0;
            this.lbl_Topic.Text = "Topic";
            // 
            // msg_dialogError
            // 
            this.msg_dialogError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msg_dialogError.Caption = null;
            this.msg_dialogError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.msg_dialogError.Parent = null;
            this.msg_dialogError.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.msg_dialogError.Text = null;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel_drag;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 552);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel_drag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.panel_drag.ResumeLayout(false);
            this.panel_drag.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_drag;
        private Bunifu.Framework.UI.BunifuTileButton btn_exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Title;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_endDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_startDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required7;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_save;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_note;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Status;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_type;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_addedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_status;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_AddedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_type;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_gender;
        private Guna.UI2.WinForms.Guna2TextBox txt_topic;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_endDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_startDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Topic;
        private Guna.UI2.WinForms.Guna2MessageDialog msg_dialogError;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required6;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_guestsList;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_guests;
    }
}