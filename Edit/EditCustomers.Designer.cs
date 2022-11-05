namespace Hil5_CRM_Project.Edit
{
    partial class EditCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomers));
            this.panel_drag = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbl_Title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dtp_addedDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_addedDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCountryCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_country = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_zip = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_city = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_Phone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox_customer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_edit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmb_addedby = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chk_status = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_WebUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_website = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_country = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_addedBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_zip = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_city = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_email = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.msg_dialogError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panel_drag.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_drag
            // 
            this.panel_drag.BackColor = System.Drawing.Color.IndianRed;
            this.panel_drag.Controls.Add(this.btn_exit);
            this.panel_drag.Controls.Add(this.lbl_Title);
            this.panel_drag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_drag.Location = new System.Drawing.Point(0, 0);
            this.panel_drag.Name = "panel_drag";
            this.panel_drag.Size = new System.Drawing.Size(806, 88);
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
            this.lbl_Title.Size = new System.Drawing.Size(159, 26);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "EDIT  CUSTOMER";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbl_id);
            this.bunifuGradientPanel1.Controls.Add(this.dtp_addedDate);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_addedDate);
            this.bunifuGradientPanel1.Controls.Add(this.lblCountryCode);
            this.bunifuGradientPanel1.Controls.Add(this.txt_phone);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_country);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_zip);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_city);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_Phone);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox_customer);
            this.bunifuGradientPanel1.Controls.Add(this.btn_edit);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_addedby);
            this.bunifuGradientPanel1.Controls.Add(this.chk_status);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_status);
            this.bunifuGradientPanel1.Controls.Add(this.txt_WebUrl);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_website);
            this.bunifuGradientPanel1.Controls.Add(this.txt_country);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_addedBy);
            this.bunifuGradientPanel1.Controls.Add(this.txt_zip);
            this.bunifuGradientPanel1.Controls.Add(this.txt_city);
            this.bunifuGradientPanel1.Controls.Add(this.txt_email);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_email);
            this.bunifuGradientPanel1.Controls.Add(this.txt_Name);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_Name);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowFrame;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.WindowFrame;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 88);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(806, 425);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // dtp_addedDate
            // 
            this.dtp_addedDate.Checked = true;
            this.dtp_addedDate.FillColor = System.Drawing.Color.Snow;
            this.dtp_addedDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_addedDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_addedDate.Location = new System.Drawing.Point(303, 386);
            this.dtp_addedDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_addedDate.MinDate = new System.DateTime(2022, 10, 21, 0, 0, 0, 0);
            this.dtp_addedDate.Name = "dtp_addedDate";
            this.dtp_addedDate.Size = new System.Drawing.Size(234, 37);
            this.dtp_addedDate.TabIndex = 18;
            this.dtp_addedDate.Value = new System.DateTime(2022, 10, 21, 0, 0, 0, 0);
            // 
            // lbl_addedDate
            // 
            this.lbl_addedDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_addedDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addedDate.ForeColor = System.Drawing.Color.Gold;
            this.lbl_addedDate.Location = new System.Drawing.Point(303, 357);
            this.lbl_addedDate.Name = "lbl_addedDate";
            this.lbl_addedDate.Size = new System.Drawing.Size(103, 23);
            this.lbl_addedDate.TabIndex = 17;
            this.lbl_addedDate.Text = "Added Date";
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCountryCode.DefaultText = "+251";
            this.lblCountryCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblCountryCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblCountryCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblCountryCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblCountryCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblCountryCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCountryCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblCountryCode.Location = new System.Drawing.Point(211, 135);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.PasswordChar = '\0';
            this.lblCountryCode.PlaceholderText = "";
            this.lblCountryCode.ReadOnly = true;
            this.lblCountryCode.SelectedText = "";
            this.lblCountryCode.Size = new System.Drawing.Size(50, 29);
            this.lblCountryCode.TabIndex = 16;
            // 
            // txt_phone
            // 
            this.txt_phone.BorderRadius = 11;
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.DefaultText = "";
            this.txt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_phone.HoverState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_phone.Location = new System.Drawing.Point(267, 133);
            this.txt_phone.MaxLength = 9;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(154, 31);
            this.txt_phone.TabIndex = 15;
            // 
            // lbl_country
            // 
            this.lbl_country.BackColor = System.Drawing.Color.Transparent;
            this.lbl_country.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.ForeColor = System.Drawing.Color.Gold;
            this.lbl_country.Location = new System.Drawing.Point(97, 240);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(66, 23);
            this.lbl_country.TabIndex = 14;
            this.lbl_country.Text = "Country";
            // 
            // lbl_zip
            // 
            this.lbl_zip.BackColor = System.Drawing.Color.Transparent;
            this.lbl_zip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zip.ForeColor = System.Drawing.Color.Gold;
            this.lbl_zip.Location = new System.Drawing.Point(99, 208);
            this.lbl_zip.Name = "lbl_zip";
            this.lbl_zip.Size = new System.Drawing.Size(25, 23);
            this.lbl_zip.TabIndex = 14;
            this.lbl_zip.Text = "Zip";
            // 
            // lbl_city
            // 
            this.lbl_city.BackColor = System.Drawing.Color.Transparent;
            this.lbl_city.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.ForeColor = System.Drawing.Color.Gold;
            this.lbl_city.Location = new System.Drawing.Point(99, 170);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(34, 23);
            this.lbl_city.TabIndex = 14;
            this.lbl_city.Text = "City";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Phone.Location = new System.Drawing.Point(99, 141);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(52, 23);
            this.lbl_Phone.TabIndex = 14;
            this.lbl_Phone.Text = "Phone";
            // 
            // pictureBox_customer
            // 
            this.pictureBox_customer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_customer.Image")));
            this.pictureBox_customer.ImageRotate = 0F;
            this.pictureBox_customer.Location = new System.Drawing.Point(563, 73);
            this.pictureBox_customer.Name = "pictureBox_customer";
            this.pictureBox_customer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_customer.Size = new System.Drawing.Size(186, 190);
            this.pictureBox_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_customer.TabIndex = 5;
            this.pictureBox_customer.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BorderColor = System.Drawing.Color.Turquoise;
            this.btn_edit.BorderRadius = 20;
            this.btn_edit.BorderThickness = 2;
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_edit.FillColor2 = System.Drawing.SystemColors.GrayText;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(582, 324);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(180, 45);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // cmb_addedby
            // 
            this.cmb_addedby.AutoRoundedCorners = true;
            this.cmb_addedby.BackColor = System.Drawing.Color.Transparent;
            this.cmb_addedby.BorderRadius = 17;
            this.cmb_addedby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_addedby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_addedby.FillColor = System.Drawing.Color.Moccasin;
            this.cmb_addedby.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_addedby.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_addedby.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_addedby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_addedby.ItemHeight = 30;
            this.cmb_addedby.Location = new System.Drawing.Point(211, 268);
            this.cmb_addedby.Name = "cmb_addedby";
            this.cmb_addedby.Size = new System.Drawing.Size(210, 36);
            this.cmb_addedby.TabIndex = 3;
            // 
            // chk_status
            // 
            this.chk_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_status.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_status.Checked = true;
            this.chk_status.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_status.ForeColor = System.Drawing.Color.White;
            this.chk_status.Location = new System.Drawing.Point(213, 345);
            this.chk_status.Name = "chk_status";
            this.chk_status.Size = new System.Drawing.Size(20, 20);
            this.chk_status.TabIndex = 2;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Gold;
            this.lbl_status.Location = new System.Drawing.Point(99, 343);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(52, 23);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Status";
            // 
            // txt_WebUrl
            // 
            this.txt_WebUrl.AutoRoundedCorners = true;
            this.txt_WebUrl.BorderRadius = 13;
            this.txt_WebUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_WebUrl.DefaultText = "";
            this.txt_WebUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_WebUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_WebUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_WebUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_WebUrl.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_WebUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_WebUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_WebUrl.Location = new System.Drawing.Point(213, 308);
            this.txt_WebUrl.Name = "txt_WebUrl";
            this.txt_WebUrl.PasswordChar = '\0';
            this.txt_WebUrl.PlaceholderText = "(Optional URL)";
            this.txt_WebUrl.SelectedText = "";
            this.txt_WebUrl.Size = new System.Drawing.Size(210, 29);
            this.txt_WebUrl.TabIndex = 1;
            // 
            // lbl_website
            // 
            this.lbl_website.BackColor = System.Drawing.Color.Transparent;
            this.lbl_website.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_website.ForeColor = System.Drawing.Color.Gold;
            this.lbl_website.Location = new System.Drawing.Point(99, 314);
            this.lbl_website.Name = "lbl_website";
            this.lbl_website.Size = new System.Drawing.Size(65, 23);
            this.lbl_website.TabIndex = 0;
            this.lbl_website.Text = "Website";
            // 
            // txt_country
            // 
            this.txt_country.AutoRoundedCorners = true;
            this.txt_country.BorderRadius = 13;
            this.txt_country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_country.DefaultText = "";
            this.txt_country.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_country.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_country.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_country.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_country.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_country.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_country.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_country.Location = new System.Drawing.Point(211, 235);
            this.txt_country.Name = "txt_country";
            this.txt_country.PasswordChar = '\0';
            this.txt_country.PlaceholderText = "";
            this.txt_country.SelectedText = "";
            this.txt_country.Size = new System.Drawing.Size(210, 29);
            this.txt_country.TabIndex = 1;
            // 
            // lbl_addedBy
            // 
            this.lbl_addedBy.BackColor = System.Drawing.Color.Transparent;
            this.lbl_addedBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addedBy.ForeColor = System.Drawing.Color.Gold;
            this.lbl_addedBy.Location = new System.Drawing.Point(97, 281);
            this.lbl_addedBy.Name = "lbl_addedBy";
            this.lbl_addedBy.Size = new System.Drawing.Size(80, 23);
            this.lbl_addedBy.TabIndex = 0;
            this.lbl_addedBy.Text = "Added By";
            // 
            // txt_zip
            // 
            this.txt_zip.AutoRoundedCorners = true;
            this.txt_zip.BorderRadius = 13;
            this.txt_zip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_zip.DefaultText = "";
            this.txt_zip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_zip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_zip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_zip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_zip.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_zip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_zip.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_zip.Location = new System.Drawing.Point(211, 202);
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.PasswordChar = '\0';
            this.txt_zip.PlaceholderText = "";
            this.txt_zip.SelectedText = "";
            this.txt_zip.Size = new System.Drawing.Size(210, 29);
            this.txt_zip.TabIndex = 1;
            // 
            // txt_city
            // 
            this.txt_city.AutoRoundedCorners = true;
            this.txt_city.BorderRadius = 13;
            this.txt_city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_city.DefaultText = "";
            this.txt_city.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_city.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_city.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_city.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_city.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_city.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_city.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_city.Location = new System.Drawing.Point(211, 169);
            this.txt_city.Name = "txt_city";
            this.txt_city.PasswordChar = '\0';
            this.txt_city.PlaceholderText = "";
            this.txt_city.SelectedText = "";
            this.txt_city.Size = new System.Drawing.Size(210, 29);
            this.txt_city.TabIndex = 1;
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
            this.txt_email.Location = new System.Drawing.Point(211, 100);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(210, 29);
            this.txt_email.TabIndex = 1;
            // 
            // lbl_email
            // 
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Gold;
            this.lbl_email.Location = new System.Drawing.Point(99, 108);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 23);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email";
            // 
            // txt_Name
            // 
            this.txt_Name.BorderRadius = 11;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "\r\n";
            this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_Name.Location = new System.Drawing.Point(213, 67);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PlaceholderText = "";
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(210, 29);
            this.txt_Name.TabIndex = 1;
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel_drag;
            this.guna2DragControl1.UseTransparentDrag = true;
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
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(714, 281);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 19;
            // 
            // EditCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 513);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel_drag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCustomers";
            this.Text = "EditCustomers";
            this.panel_drag.ResumeLayout(false);
            this.panel_drag.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_drag;
        private Bunifu.Framework.UI.BunifuTileButton btn_exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Title;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_addedDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_addedDate;
        private Guna.UI2.WinForms.Guna2TextBox lblCountryCode;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_country;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_zip;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_city;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Phone;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_customer;
        private Guna.UI2.WinForms.Guna2GradientButton btn_edit;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_addedby;
        private Bunifu.Framework.UI.BunifuCheckbox chk_status;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_status;
        private Guna.UI2.WinForms.Guna2TextBox txt_WebUrl;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_website;
        private Guna.UI2.WinForms.Guna2TextBox txt_country;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_addedBy;
        private Guna.UI2.WinForms.Guna2TextBox txt_zip;
        private Guna.UI2.WinForms.Guna2TextBox txt_city;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Name;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2MessageDialog msg_dialogError;
        private System.Windows.Forms.Label lbl_id;
    }
}