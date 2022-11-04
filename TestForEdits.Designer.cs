namespace Hil5_CRM_Project
{
    partial class TestForEdits
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
            this.btnEditOrg = new System.Windows.Forms.Button();
            this.txtIdOrg = new System.Windows.Forms.TextBox();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.btn_editCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditOrg
            // 
            this.btnEditOrg.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrg.Location = new System.Drawing.Point(53, 64);
            this.btnEditOrg.Name = "btnEditOrg";
            this.btnEditOrg.Size = new System.Drawing.Size(162, 92);
            this.btnEditOrg.TabIndex = 0;
            this.btnEditOrg.Text = "Edit Organization";
            this.btnEditOrg.UseVisualStyleBackColor = true;
            this.btnEditOrg.Click += new System.EventHandler(this.btnEditOrg_Click);
            // 
            // txtIdOrg
            // 
            this.txtIdOrg.Location = new System.Drawing.Point(245, 136);
            this.txtIdOrg.Name = "txtIdOrg";
            this.txtIdOrg.Size = new System.Drawing.Size(171, 20);
            this.txtIdOrg.TabIndex = 1;
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(245, 234);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(171, 20);
            this.txtIdCustomer.TabIndex = 1;
            // 
            // btn_editCustomer
            // 
            this.btn_editCustomer.Location = new System.Drawing.Point(53, 199);
            this.btn_editCustomer.Name = "btn_editCustomer";
            this.btn_editCustomer.Size = new System.Drawing.Size(162, 55);
            this.btn_editCustomer.TabIndex = 2;
            this.btn_editCustomer.Text = "Edit Customer";
            this.btn_editCustomer.UseVisualStyleBackColor = true;
            this.btn_editCustomer.Click += new System.EventHandler(this.btn_editCustomer_Click);
            // 
            // TestForEdits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 537);
            this.Controls.Add(this.btn_editCustomer);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.txtIdOrg);
            this.Controls.Add(this.btnEditOrg);
            this.Name = "TestForEdits";
            this.Text = "TestForEdits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditOrg;
        private System.Windows.Forms.TextBox txtIdOrg;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Button btn_editCustomer;
    }
}