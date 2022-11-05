namespace AddTeam
{
    partial class TeamCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamCard));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panLeft = new System.Windows.Forms.Panel();
            this.panRight = new System.Windows.Forms.Panel();
            this.pic_team = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_dept = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_gender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMore = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_team)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panLeft);
            this.bunifuGradientPanel1.Controls.Add(this.panRight);
            this.bunifuGradientPanel1.Controls.Add(this.pic_team);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_dept);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_gender);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_name);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(329, 324);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // panLeft
            // 
            this.panLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeft.Location = new System.Drawing.Point(0, 0);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(14, 324);
            this.panLeft.TabIndex = 5;
            // 
            // panRight
            // 
            this.panRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRight.Location = new System.Drawing.Point(315, 0);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(14, 324);
            this.panRight.TabIndex = 4;
            // 
            // pic_team
            // 
            this.pic_team.BackColor = System.Drawing.Color.Transparent;
            this.pic_team.Image = ((System.Drawing.Image)(resources.GetObject("pic_team.Image")));
            this.pic_team.ImageRotate = 0F;
            this.pic_team.Location = new System.Drawing.Point(74, 25);
            this.pic_team.Name = "pic_team";
            this.pic_team.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_team.Size = new System.Drawing.Size(139, 159);
            this.pic_team.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_team.TabIndex = 2;
            this.pic_team.TabStop = false;
            this.pic_team.UseTransparentBackground = true;
            // 
            // lbl_dept
            // 
            this.lbl_dept.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dept.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dept.ForeColor = System.Drawing.Color.White;
            this.lbl_dept.Location = new System.Drawing.Point(100, 267);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(51, 26);
            this.lbl_dept.TabIndex = 3;
            this.lbl_dept.Text = "Dept";
            // 
            // lbl_gender
            // 
            this.lbl_gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gender.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_gender.Location = new System.Drawing.Point(100, 235);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(65, 26);
            this.lbl_gender.TabIndex = 3;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(100, 203);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 26);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            // 
            // lblMore
            // 
            this.lblMore.AutoSize = true;
            this.lblMore.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMore.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblMore.Location = new System.Drawing.Point(312, 359);
            this.lblMore.Name = "lblMore";
            this.lblMore.Size = new System.Drawing.Size(57, 23);
            this.lblMore.TabIndex = 7;
            this.lblMore.Text = "More";
            // 
            // TeamCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Controls.Add(this.lblMore);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "TeamCard";
            this.Size = new System.Drawing.Size(329, 348);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_team)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_team;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_dept;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_gender;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_name;
        private System.Windows.Forms.Panel panRight;
        private System.Windows.Forms.Panel panLeft;
        private System.Windows.Forms.Label lblMore;
    }
}
