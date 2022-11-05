namespace Hil5_CRM_Project.Edit
{
    partial class EditOrganization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrganization));
            this.panel_drag2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbl_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lblCountryCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_attach = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox_Logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbl_Address = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_email = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_Phone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.msg_dialogError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel_drag2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_drag2
            // 
            this.panel_drag2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(41)))));
            this.panel_drag2.Controls.Add(this.btn_exit);
            this.panel_drag2.Controls.Add(this.lbl_title);
            this.panel_drag2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_drag2.Location = new System.Drawing.Point(0, 0);
            this.panel_drag2.Name = "panel_drag2";
            this.panel_drag2.Size = new System.Drawing.Size(541, 108);
            this.panel_drag2.TabIndex = 5;
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
            this.btn_exit.Location = new System.Drawing.Point(483, 35);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(43, 46);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Coral;
            this.lbl_title.Location = new System.Drawing.Point(188, 48);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(233, 33);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "EDIT COMPANY";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbl_id);
            this.bunifuGradientPanel1.Controls.Add(this.lblCountryCode);
            this.bunifuGradientPanel1.Controls.Add(this.btn_attach);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox_Logo);
            this.bunifuGradientPanel1.Controls.Add(this.btn_save);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_Address);
            this.bunifuGradientPanel1.Controls.Add(this.txt_address);
            this.bunifuGradientPanel1.Controls.Add(this.txt_name);
            this.bunifuGradientPanel1.Controls.Add(this.txt_email);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_name);
            this.bunifuGradientPanel1.Controls.Add(this.txt_phone);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_email);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_Phone);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowFrame;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.WindowFrame;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 108);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(541, 430);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(408, 329);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 14;
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
            this.lblCountryCode.Location = new System.Drawing.Point(211, 235);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.PasswordChar = '\0';
            this.lblCountryCode.PlaceholderText = "";
            this.lblCountryCode.ReadOnly = true;
            this.lblCountryCode.SelectedText = "";
            this.lblCountryCode.Size = new System.Drawing.Size(50, 29);
            this.lblCountryCode.TabIndex = 13;
            // 
            // btn_attach
            // 
            this.btn_attach.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_attach.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_attach.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_attach.Image = ((System.Drawing.Image)(resources.GetObject("btn_attach.Image")));
            this.btn_attach.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_attach.ImageRotate = 0F;
            this.btn_attach.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_attach.IndicateFocus = true;
            this.btn_attach.Location = new System.Drawing.Point(343, 77);
            this.btn_attach.Name = "btn_attach";
            this.btn_attach.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_attach.Size = new System.Drawing.Size(48, 52);
            this.btn_attach.TabIndex = 12;
            this.btn_attach.Click += new System.EventHandler(this.btn_attach_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.ImageRotate = 0F;
            this.pictureBox_Logo.Location = new System.Drawing.Point(232, 30);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_Logo.Size = new System.Drawing.Size(105, 99);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Logo.TabIndex = 2;
            this.pictureBox_Logo.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.BorderColor = System.Drawing.Color.Turquoise;
            this.btn_save.BorderRadius = 20;
            this.btn_save.BorderThickness = 2;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_save.FillColor2 = System.Drawing.SystemColors.GrayText;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(188, 329);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 45);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "EDIT";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_Address
            // 
            this.lbl_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Address.Location = new System.Drawing.Point(97, 281);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(65, 23);
            this.lbl_Address.TabIndex = 0;
            this.lbl_Address.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.BorderRadius = 11;
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_address.Location = new System.Drawing.Point(211, 270);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderText = "";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(233, 29);
            this.txt_address.TabIndex = 1;
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
            this.txt_name.Location = new System.Drawing.Point(211, 165);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(233, 29);
            this.txt_name.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.BorderRadius = 11;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "\r\n";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.HotPink;
            this.txt_email.Location = new System.Drawing.Point(211, 200);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(233, 29);
            this.txt_email.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Gold;
            this.lbl_name.Location = new System.Drawing.Point(97, 171);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 23);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
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
            this.txt_phone.Location = new System.Drawing.Point(267, 235);
            this.txt_phone.MaxLength = 9;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(177, 29);
            this.txt_phone.TabIndex = 1;
            // 
            // lbl_email
            // 
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Gold;
            this.lbl_email.Location = new System.Drawing.Point(97, 206);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 23);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Phone.Location = new System.Drawing.Point(97, 241);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(52, 23);
            this.lbl_Phone.TabIndex = 0;
            this.lbl_Phone.Text = "Phone";
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
            // EditOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 538);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel_drag2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditOrganization";
            this.Text = "EditOrganization";
            this.panel_drag2.ResumeLayout(false);
            this.panel_drag2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_drag2;
        private Bunifu.Framework.UI.BunifuTileButton btn_exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_title;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox lblCountryCode;
        private Guna.UI2.WinForms.Guna2ImageButton btn_attach;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_Logo;
        private Guna.UI2.WinForms.Guna2GradientButton btn_save;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Address;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_email;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Phone;
        private Guna.UI2.WinForms.Guna2MessageDialog msg_dialogError;
        private System.Windows.Forms.Label lbl_id;
    }
}