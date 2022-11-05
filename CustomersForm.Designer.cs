namespace Hil5_CRM_Project
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_update = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_pdfExport = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_onleave = new Guna.UI2.WinForms.Guna2Button();
            this.btn_promote = new Guna.UI2.WinForms.Guna2Button();
            this.btn_active = new Guna.UI2.WinForms.Guna2Button();
            this.btn_all = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Customer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_CustFilter = new System.Windows.Forms.Label();
            this.flp_customers = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_pdfExport);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 60);
            this.panel1.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_add.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_add.ImageRotate = 0F;
            this.btn_add.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_add.Location = new System.Drawing.Point(573, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.PressedState.ImageSize = new System.Drawing.Size(71, 76);
            this.btn_add.Size = new System.Drawing.Size(58, 60);
            this.btn_add.TabIndex = 6;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_update.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_update.ImageRotate = 0F;
            this.btn_update.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_update.Location = new System.Drawing.Point(529, 14);
            this.btn_update.MaximumSize = new System.Drawing.Size(40, 40);
            this.btn_update.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_update.Name = "btn_update";
            this.btn_update.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_update.Size = new System.Drawing.Size(40, 40);
            this.btn_update.TabIndex = 7;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_pdfExport
            // 
            this.btn_pdfExport.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_pdfExport.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_pdfExport.Image = global::Hil5_CRM_Project.Properties.Resources.icons8_export_pdf_48;
            this.btn_pdfExport.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_pdfExport.ImageRotate = 0F;
            this.btn_pdfExport.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_pdfExport.Location = new System.Drawing.Point(633, 8);
            this.btn_pdfExport.Name = "btn_pdfExport";
            this.btn_pdfExport.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_pdfExport.Size = new System.Drawing.Size(45, 48);
            this.btn_pdfExport.TabIndex = 8;
            this.btn_pdfExport.Click += new System.EventHandler(this.btn_pdfExport_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_delete.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_delete.ImageRotate = 0F;
            this.btn_delete.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_delete.Location = new System.Drawing.Point(680, 7);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_delete.Size = new System.Drawing.Size(45, 48);
            this.btn_delete.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_onleave);
            this.panel4.Controls.Add(this.btn_promote);
            this.panel4.Controls.Add(this.btn_active);
            this.panel4.Controls.Add(this.btn_all);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(905, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 60);
            this.panel4.TabIndex = 1;
            // 
            // btn_onleave
            // 
            this.btn_onleave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_onleave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.btn_onleave.BorderRadius = 13;
            this.btn_onleave.BorderThickness = 2;
            this.btn_onleave.CustomizableEdges.BottomLeft = false;
            this.btn_onleave.CustomizableEdges.TopLeft = false;
            this.btn_onleave.CustomizableEdges.TopRight = false;
            this.btn_onleave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_onleave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_onleave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_onleave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_onleave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_onleave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_onleave.ForeColor = System.Drawing.Color.White;
            this.btn_onleave.Location = new System.Drawing.Point(159, 26);
            this.btn_onleave.Name = "btn_onleave";
            this.btn_onleave.Size = new System.Drawing.Size(91, 31);
            this.btn_onleave.TabIndex = 1;
            this.btn_onleave.Text = "On Leave";
            // 
            // btn_promote
            // 
            this.btn_promote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_promote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.btn_promote.BorderRadius = 13;
            this.btn_promote.BorderThickness = 2;
            this.btn_promote.CustomizableEdges.BottomLeft = false;
            this.btn_promote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_promote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_promote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_promote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_promote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_promote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_promote.ForeColor = System.Drawing.Color.White;
            this.btn_promote.Location = new System.Drawing.Point(251, 26);
            this.btn_promote.Name = "btn_promote";
            this.btn_promote.Size = new System.Drawing.Size(91, 31);
            this.btn_promote.TabIndex = 1;
            this.btn_promote.Text = "Promote";
            // 
            // btn_active
            // 
            this.btn_active.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_active.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.btn_active.BorderRadius = 13;
            this.btn_active.BorderThickness = 2;
            this.btn_active.CustomizableEdges.BottomRight = false;
            this.btn_active.CustomizableEdges.TopLeft = false;
            this.btn_active.CustomizableEdges.TopRight = false;
            this.btn_active.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_active.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_active.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_active.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_active.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_active.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_active.ForeColor = System.Drawing.Color.White;
            this.btn_active.Location = new System.Drawing.Point(87, 26);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(69, 31);
            this.btn_active.TabIndex = 1;
            this.btn_active.Text = "Active";
            // 
            // btn_all
            // 
            this.btn_all.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_all.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.btn_all.BorderRadius = 13;
            this.btn_all.BorderThickness = 2;
            this.btn_all.CustomizableEdges.BottomRight = false;
            this.btn_all.CustomizableEdges.TopRight = false;
            this.btn_all.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_all.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_all.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_all.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_all.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_all.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all.ForeColor = System.Drawing.Color.White;
            this.btn_all.Location = new System.Drawing.Point(18, 26);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(66, 31);
            this.btn_all.TabIndex = 1;
            this.btn_all.Text = "All";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Silver;
            this.guna2TextBox1.BorderRadius = 13;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = global::Hil5_CRM_Project.Properties.Resources.icons8_search_more_32;
            this.guna2TextBox1.Location = new System.Drawing.Point(3, 26);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(247, 27);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = global::Hil5_CRM_Project.Properties.Resources.icons8_search_641;
            this.btn_search.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_search.Location = new System.Drawing.Point(256, 26);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_search.Size = new System.Drawing.Size(32, 27);
            this.btn_search.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_CustFilter);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 42);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customers";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flp_customers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1254, 400);
            this.panel3.TabIndex = 6;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icons8-contact-64.png");
            this.imageList.Images.SetKeyName(1, "icons8-remove-48.png");
            this.imageList.Images.SetKeyName(2, "icons8-active-58.png");
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.lb_Customer);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1254, 39);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Hil5_CRM_Project.Properties.Resources.icons8_customer_insight_50;
            this.pictureBox1.Location = new System.Drawing.Point(991, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Customer
            // 
            this.lb_Customer.AutoSize = true;
            this.lb_Customer.BackColor = System.Drawing.Color.Transparent;
            this.lb_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Customer.ForeColor = System.Drawing.Color.White;
            this.lb_Customer.Location = new System.Drawing.Point(1042, 9);
            this.lb_Customer.Name = "lb_Customer";
            this.lb_Customer.Size = new System.Drawing.Size(95, 20);
            this.lb_Customer.TabIndex = 0;
            this.lb_Customer.Text = "Customers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filter: ";
            // 
            // lb_CustFilter
            // 
            this.lb_CustFilter.AutoSize = true;
            this.lb_CustFilter.BackColor = System.Drawing.Color.Transparent;
            this.lb_CustFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_CustFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustFilter.ForeColor = System.Drawing.Color.White;
            this.lb_CustFilter.Location = new System.Drawing.Point(121, 21);
            this.lb_CustFilter.Name = "lb_CustFilter";
            this.lb_CustFilter.Size = new System.Drawing.Size(13, 13);
            this.lb_CustFilter.TabIndex = 0;
            this.lb_CustFilter.Text = "0";
            // 
            // flp_customers
            // 
            this.flp_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_customers.Location = new System.Drawing.Point(0, 0);
            this.flp_customers.Name = "flp_customers";
            this.flp_customers.Size = new System.Drawing.Size(1254, 400);
            this.flp_customers.TabIndex = 1;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1254, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Customer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList;
        private Guna.UI2.WinForms.Guna2CircleButton btn_search;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btn_onleave;
        private Guna.UI2.WinForms.Guna2Button btn_active;
        private Guna.UI2.WinForms.Guna2Button btn_all;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btn_promote;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btn_add;
        private Guna.UI2.WinForms.Guna2ImageButton btn_update;
        private Guna.UI2.WinForms.Guna2ImageButton btn_pdfExport;
        private Guna.UI2.WinForms.Guna2ImageButton btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_CustFilter;
        private System.Windows.Forms.FlowLayoutPanel flp_customers;
    }
}