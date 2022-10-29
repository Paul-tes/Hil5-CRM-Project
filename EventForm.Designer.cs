namespace Hil5_CRM_Project
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_onleave = new Guna.UI2.WinForms.Guna2Button();
            this.btn_all = new Guna.UI2.WinForms.Guna2Button();
            this.btn_active = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_add = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_update = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_pdfExport = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_customor = new System.Windows.Forms.DataGridView();
            this.col_icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_addedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_active = new System.Windows.Forms.DataGridViewImageColumn();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Leads = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customor)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 44);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Events";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.guna2TextBox1);
            this.panel4.Controls.Add(this.guna2CircleButton1);
            this.panel4.Controls.Add(this.btn_add);
            this.panel4.Controls.Add(this.btn_update);
            this.panel4.Controls.Add(this.btn_pdfExport);
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1222, 60);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_onleave);
            this.panel3.Controls.Add(this.btn_all);
            this.panel3.Controls.Add(this.btn_active);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(912, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 60);
            this.panel3.TabIndex = 4;
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
            this.btn_onleave.Location = new System.Drawing.Point(210, 23);
            this.btn_onleave.Name = "btn_onleave";
            this.btn_onleave.Size = new System.Drawing.Size(91, 31);
            this.btn_onleave.TabIndex = 1;
            this.btn_onleave.Text = "Up Coming";
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
            this.btn_all.Location = new System.Drawing.Point(69, 23);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(66, 31);
            this.btn_all.TabIndex = 1;
            this.btn_all.Text = "All";
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
            this.btn_active.Location = new System.Drawing.Point(138, 23);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(69, 31);
            this.btn_active.TabIndex = 1;
            this.btn_active.Text = "Passed";
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
            this.guna2TextBox1.Location = new System.Drawing.Point(15, 23);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(247, 27);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = global::Hil5_CRM_Project.Properties.Resources.icons8_search_641;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2CircleButton1.Location = new System.Drawing.Point(268, 22);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(32, 27);
            this.guna2CircleButton1.TabIndex = 3;
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
            this.btn_add.Location = new System.Drawing.Point(553, -2);
            this.btn_add.Name = "btn_add";
            this.btn_add.PressedState.ImageSize = new System.Drawing.Size(71, 76);
            this.btn_add.Size = new System.Drawing.Size(58, 60);
            this.btn_add.TabIndex = 1;
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
            this.btn_update.Location = new System.Drawing.Point(509, 12);
            this.btn_update.MaximumSize = new System.Drawing.Size(40, 40);
            this.btn_update.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_update.Name = "btn_update";
            this.btn_update.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_update.Size = new System.Drawing.Size(40, 40);
            this.btn_update.TabIndex = 1;
            // 
            // btn_pdfExport
            // 
            this.btn_pdfExport.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_pdfExport.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_pdfExport.Image = global::Hil5_CRM_Project.Properties.Resources.icons8_export_pdf_48;
            this.btn_pdfExport.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_pdfExport.ImageRotate = 0F;
            this.btn_pdfExport.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_pdfExport.Location = new System.Drawing.Point(613, 6);
            this.btn_pdfExport.Name = "btn_pdfExport";
            this.btn_pdfExport.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_pdfExport.Size = new System.Drawing.Size(45, 48);
            this.btn_pdfExport.TabIndex = 1;
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
            this.btn_delete.Location = new System.Drawing.Point(660, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_delete.Size = new System.Drawing.Size(45, 48);
            this.btn_delete.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 60);
            this.panel1.TabIndex = 8;
            // 
            // dgv_customor
            // 
            this.dgv_customor.AllowUserToAddRows = false;
            this.dgv_customor.AllowUserToDeleteRows = false;
            this.dgv_customor.AllowUserToOrderColumns = true;
            this.dgv_customor.AllowUserToResizeRows = false;
            this.dgv_customor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_customor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dgv_customor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_customor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_customor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customor.ColumnHeadersHeight = 40;
            this.dgv_customor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_customor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_icon,
            this.col_id,
            this.col_name,
            this.col_type,
            this.col_status,
            this.col_addedBy,
            this.col_note,
            this.col_startTime,
            this.col_startDate,
            this.col_endDate,
            this.col_endTime,
            this.col_photo,
            this.col_active});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_customor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_customor.EnableHeadersVisualStyles = false;
            this.dgv_customor.Location = new System.Drawing.Point(0, 99);
            this.dgv_customor.Name = "dgv_customor";
            this.dgv_customor.RowHeadersVisible = false;
            this.dgv_customor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customor.Size = new System.Drawing.Size(1222, 367);
            this.dgv_customor.TabIndex = 10;
            // 
            // col_icon
            // 
            this.col_icon.FillWeight = 23.31082F;
            this.col_icon.HeaderText = "";
            this.col_icon.Name = "col_icon";
            this.col_icon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_icon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_id
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.col_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_id.FillWeight = 38.85136F;
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_name
            // 
            this.col_name.FillWeight = 77.70273F;
            this.col_name.HeaderText = "Topic";
            this.col_name.Name = "col_name";
            // 
            // col_type
            // 
            this.col_type.HeaderText = "Type";
            this.col_type.Name = "col_type";
            // 
            // col_status
            // 
            this.col_status.HeaderText = "Status";
            this.col_status.Name = "col_status";
            // 
            // col_addedBy
            // 
            this.col_addedBy.FillWeight = 77.70273F;
            this.col_addedBy.HeaderText = "Added By";
            this.col_addedBy.Name = "col_addedBy";
            // 
            // col_note
            // 
            this.col_note.HeaderText = "Note";
            this.col_note.Name = "col_note";
            // 
            // col_startTime
            // 
            this.col_startTime.HeaderText = "Start Time";
            this.col_startTime.Name = "col_startTime";
            // 
            // col_startDate
            // 
            this.col_startDate.HeaderText = "Start Date";
            this.col_startDate.Name = "col_startDate";
            // 
            // col_endDate
            // 
            this.col_endDate.HeaderText = "End Time";
            this.col_endDate.Name = "col_endDate";
            // 
            // col_endTime
            // 
            this.col_endTime.HeaderText = "End Time";
            this.col_endTime.Name = "col_endTime";
            // 
            // col_photo
            // 
            this.col_photo.FillWeight = 38.85136F;
            this.col_photo.HeaderText = "Photo";
            this.col_photo.Name = "col_photo";
            // 
            // col_active
            // 
            this.col_active.FillWeight = 50F;
            this.col_active.HeaderText = "Active";
            this.col_active.Name = "col_active";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.lb_Leads);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1222, 39);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Hil5_CRM_Project.Properties.Resources.icons8_schedule_501;
            this.pictureBox1.Location = new System.Drawing.Point(1023, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Leads
            // 
            this.lb_Leads.AutoSize = true;
            this.lb_Leads.BackColor = System.Drawing.Color.Transparent;
            this.lb_Leads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Leads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Leads.ForeColor = System.Drawing.Color.White;
            this.lb_Leads.Location = new System.Drawing.Point(1069, 9);
            this.lb_Leads.Name = "lb_Leads";
            this.lb_Leads.Size = new System.Drawing.Size(64, 20);
            this.lb_Leads.TabIndex = 0;
            this.lb_Leads.Text = "Events";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1222, 510);
            this.Controls.Add(this.dgv_customor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customor)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Leads;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btn_onleave;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_active;
        private Guna.UI2.WinForms.Guna2ImageButton btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_all;
        private Guna.UI2.WinForms.Guna2ImageButton btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_customor;
        private System.Windows.Forms.DataGridViewImageColumn col_icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_addedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_endTime;
        private System.Windows.Forms.DataGridViewImageColumn col_photo;
        private System.Windows.Forms.DataGridViewImageColumn col_active;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ImageButton btn_pdfExport;
    }
}