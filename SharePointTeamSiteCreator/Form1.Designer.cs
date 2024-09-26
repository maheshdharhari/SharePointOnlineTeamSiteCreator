namespace SharePointTeamSiteCreator
{
    partial class Form1
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
            this.btnCreateSite = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSiteDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdminSiteUrl = new System.Windows.Forms.TextBox();
            this.txtTenantId = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtSiteDisplayName = new System.Windows.Forms.TextBox();
            this.textSiteOwner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateSite
            // 
            this.btnCreateSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateSite.Location = new System.Drawing.Point(292, 190);
            this.btnCreateSite.Name = "btnCreateSite";
            this.btnCreateSite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateSite.Size = new System.Drawing.Size(117, 23);
            this.btnCreateSite.TabIndex = 12;
            this.btnCreateSite.Text = "&Create Team Site";
            this.btnCreateSite.UseVisualStyleBackColor = true;
            this.btnCreateSite.Click += new System.EventHandler(this.btnCreateSite_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAdminSiteUrl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTenantId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtClientId, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateSite, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtSiteDescription, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtSiteDisplayName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textSiteOwner, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 216);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSiteDescription
            // 
            this.txtSiteDescription.Location = new System.Drawing.Point(90, 133);
            this.txtSiteDescription.Multiline = true;
            this.txtSiteDescription.Name = "txtSiteDescription";
            this.txtSiteDescription.Size = new System.Drawing.Size(318, 51);
            this.txtSiteDescription.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Site &Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Site &Owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Client ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tenant &ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "&Tenant";
            // 
            // txtAdminSiteUrl
            // 
            this.txtAdminSiteUrl.Location = new System.Drawing.Point(90, 3);
            this.txtAdminSiteUrl.Name = "txtAdminSiteUrl";
            this.txtAdminSiteUrl.Size = new System.Drawing.Size(318, 20);
            this.txtAdminSiteUrl.TabIndex = 1;
            // 
            // txtTenantId
            // 
            this.txtTenantId.Location = new System.Drawing.Point(90, 29);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.Size = new System.Drawing.Size(318, 20);
            this.txtTenantId.TabIndex = 3;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(90, 55);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(318, 20);
            this.txtClientId.TabIndex = 5;
            // 
            // txtSiteDisplayName
            // 
            this.txtSiteDisplayName.Location = new System.Drawing.Point(90, 107);
            this.txtSiteDisplayName.Name = "txtSiteDisplayName";
            this.txtSiteDisplayName.Size = new System.Drawing.Size(318, 20);
            this.txtSiteDisplayName.TabIndex = 9;
            // 
            // textSiteOwner
            // 
            this.textSiteOwner.Location = new System.Drawing.Point(90, 81);
            this.textSiteOwner.Name = "textSiteOwner";
            this.textSiteOwner.Size = new System.Drawing.Size(318, 20);
            this.textSiteOwner.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Site &Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 249);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateSite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenantId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtSiteDisplayName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSiteDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdminSiteUrl;
        private System.Windows.Forms.TextBox textSiteOwner;
        private System.Windows.Forms.Label label3;
    }
}

