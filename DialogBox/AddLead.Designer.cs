namespace Hil5_CRM_Project.DialogBox
{
    partial class AddLead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLead));
            this.panel_drag = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbl_Title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_required4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_required5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_required3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_required2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_required1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmb_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_addedBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_note = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_addedBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_note = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_source = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_email = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.msg_dialogError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.cmb_source = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.panel_drag.Size = new System.Drawing.Size(822, 88);
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
            this.btn_exit.Location = new System.Drawing.Point(755, 33);
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
            this.lbl_Title.Location = new System.Drawing.Point(49, 33);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(51, 26);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "LEAD";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required4);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required5);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required3);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required2);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_required1);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_source);
            this.bunifuGradientPanel1.Controls.Add(this.btn_save);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_status);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_addedBy);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_status);
            this.bunifuGradientPanel1.Controls.Add(this.txt_note);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_addedBy);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_note);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_source);
            this.bunifuGradientPanel1.Controls.Add(this.txt_email);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_email);
            this.bunifuGradientPanel1.Controls.Add(this.txt_name);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_Name);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowFrame;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.WindowFrame;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 88);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(822, 464);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // lbl_required4
            // 
            this.lbl_required4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_required4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_required4.ForeColor = System.Drawing.Color.Red;
            this.lbl_required4.Location = new System.Drawing.Point(149, 181);
            this.lbl_required4.Name = "lbl_required4";
            this.lbl_required4.Size = new System.Drawing.Size(13, 24);
            this.lbl_required4.TabIndex = 10;
            this.lbl_required4.Text = "*";
            // 
            // lbl_required5
            // 
            this.lbl_required5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_required5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_required5.ForeColor = System.Drawing.Color.Red;
            this.lbl_required5.Location = new System.Drawing.Point(175, 218);
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
            this.lbl_required3.Location = new System.Drawing.Point(156, 136);
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
            this.lbl_required2.Location = new System.Drawing.Point(147, 107);
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
            this.lbl_required1.Location = new System.Drawing.Point(149, 72);
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
            this.btn_save.Location = new System.Drawing.Point(582, 324);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 45);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "SAVE";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_status
            // 
            this.cmb_status.AutoRoundedCorners = true;
            this.cmb_status.BackColor = System.Drawing.Color.Transparent;
            this.cmb_status.BorderRadius = 17;
            this.cmb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FillColor = System.Drawing.Color.Moccasin;
            this.cmb_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_status.ItemHeight = 30;
            this.cmb_status.Items.AddRange(new object[] {
            "Intern",
            "Contract",
            "Full-time",
            "Part-time"});
            this.cmb_status.Location = new System.Drawing.Point(213, 168);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(210, 36);
            this.cmb_status.TabIndex = 3;
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
            this.cmb_addedBy.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cmb_addedBy.Location = new System.Drawing.Point(214, 206);
            this.cmb_addedBy.Name = "cmb_addedBy";
            this.cmb_addedBy.Size = new System.Drawing.Size(210, 36);
            this.cmb_addedBy.TabIndex = 3;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Gold;
            this.lbl_status.Location = new System.Drawing.Point(98, 182);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(52, 23);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Status";
            // 
            // txt_note
            // 
            this.txt_note.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_note.BorderRadius = 7;
            this.txt_note.BorderThickness = 2;
            this.txt_note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_note.DefaultText = "";
            this.txt_note.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_note.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_note.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_note.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_note.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_note.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_note.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_note.Location = new System.Drawing.Point(215, 246);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.PasswordChar = '\0';
            this.txt_note.PlaceholderText = "(Optional)";
            this.txt_note.SelectedText = "";
            this.txt_note.Size = new System.Drawing.Size(209, 70);
            this.txt_note.TabIndex = 1;
            // 
            // lbl_addedBy
            // 
            this.lbl_addedBy.BackColor = System.Drawing.Color.Transparent;
            this.lbl_addedBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addedBy.ForeColor = System.Drawing.Color.Gold;
            this.lbl_addedBy.Location = new System.Drawing.Point(98, 223);
            this.lbl_addedBy.Name = "lbl_addedBy";
            this.lbl_addedBy.Size = new System.Drawing.Size(80, 23);
            this.lbl_addedBy.TabIndex = 0;
            this.lbl_addedBy.Text = "Added By";
            // 
            // lbl_note
            // 
            this.lbl_note.BackColor = System.Drawing.Color.Transparent;
            this.lbl_note.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_note.ForeColor = System.Drawing.Color.Gold;
            this.lbl_note.Location = new System.Drawing.Point(99, 258);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(42, 23);
            this.lbl_note.TabIndex = 0;
            this.lbl_note.Text = "Note";
            // 
            // lbl_source
            // 
            this.lbl_source.BackColor = System.Drawing.Color.Transparent;
            this.lbl_source.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_source.ForeColor = System.Drawing.Color.Gold;
            this.lbl_source.Location = new System.Drawing.Point(99, 141);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(56, 23);
            this.lbl_source.TabIndex = 0;
            this.lbl_source.Text = "Source";
            // 
            // txt_email
            // 
            this.txt_email.AutoRoundedCorners = true;
            this.txt_email.BorderRadius = 13;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(213, 98);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(210, 29);
            this.txt_email.TabIndex = 1;
            this.txt_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // lbl_email
            // 
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Gold;
            this.lbl_email.Location = new System.Drawing.Point(97, 107);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 23);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email";
            // 
            // txt_name
            // 
            this.txt_name.BorderRadius = 11;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "\r\n";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_name.Location = new System.Drawing.Point(213, 67);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(210, 29);
            this.txt_name.TabIndex = 1;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // lbl_Name
            // 
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Name.Location = new System.Drawing.Point(99, 73);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(51, 23);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
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
            // cmb_source
            // 
            this.cmb_source.AutoRoundedCorners = true;
            this.cmb_source.BackColor = System.Drawing.Color.Transparent;
            this.cmb_source.BorderRadius = 17;
            this.cmb_source.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_source.FillColor = System.Drawing.Color.Moccasin;
            this.cmb_source.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_source.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_source.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_source.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_source.ItemHeight = 30;
            this.cmb_source.Items.AddRange(new object[] {
            "call",
            "website"});
            this.cmb_source.Location = new System.Drawing.Point(213, 130);
            this.cmb_source.Name = "cmb_source";
            this.cmb_source.Size = new System.Drawing.Size(210, 36);
            this.cmb_source.TabIndex = 3;
            // 
            // AddLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 552);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel_drag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddLead";
            this.Text = "AddLead";
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_required1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_save;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_status;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_addedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_status;
        private Guna.UI2.WinForms.Guna2TextBox txt_note;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_addedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_note;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_source;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Name;
        private Guna.UI2.WinForms.Guna2MessageDialog msg_dialogError;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_source;
    }
}