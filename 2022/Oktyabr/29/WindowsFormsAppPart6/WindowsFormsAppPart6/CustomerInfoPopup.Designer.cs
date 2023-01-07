namespace WindowsFormsAppPart6
{
    partial class CustomerInfoPopup
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.customerInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.customerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.closeBtn.Location = new System.Drawing.Point(272, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(45, 35);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // customerInfo
            // 
            this.customerInfo.Controls.Add(this.txtAddress);
            this.customerInfo.Controls.Add(this.txtCity);
            this.customerInfo.Controls.Add(this.label8);
            this.customerInfo.Controls.Add(this.txtCountry);
            this.customerInfo.Controls.Add(this.label7);
            this.customerInfo.Controls.Add(this.txtPhone);
            this.customerInfo.Controls.Add(this.label6);
            this.customerInfo.Controls.Add(this.txtEmail);
            this.customerInfo.Controls.Add(this.label5);
            this.customerInfo.Controls.Add(this.txtSurname);
            this.customerInfo.Controls.Add(this.label4);
            this.customerInfo.Controls.Add(this.txtName);
            this.customerInfo.Controls.Add(this.label3);
            this.customerInfo.Controls.Add(this.txtId);
            this.customerInfo.Controls.Add(this.label2);
            this.customerInfo.Controls.Add(this.label1);
            this.customerInfo.Location = new System.Drawing.Point(12, 26);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(254, 204);
            this.customerInfo.TabIndex = 1;
            this.customerInfo.TabStop = false;
            this.customerInfo.Text = "Müştəri Məlumatları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ölkə";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Şəhər";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ünvan";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(61, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(61, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 13);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.AutoSize = true;
            this.txtSurname.Location = new System.Drawing.Point(61, 48);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(0, 13);
            this.txtSurname.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(61, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(0, 13);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(61, 74);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(0, 13);
            this.txtPhone.TabIndex = 2;
            // 
            // txtCountry
            // 
            this.txtCountry.AutoSize = true;
            this.txtCountry.Location = new System.Drawing.Point(61, 87);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(0, 13);
            this.txtCountry.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.AutoSize = true;
            this.txtCity.Location = new System.Drawing.Point(61, 100);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(0, 13);
            this.txtCity.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(61, 113);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(0, 13);
            this.txtAddress.TabIndex = 2;
            // 
            // CustomerInfoPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 242);
            this.Controls.Add(this.customerInfo);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInfoPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müştəri haqqında məlumat";
            this.Load += new System.EventHandler(this.CustomerInfoPopup_Load);
            this.customerInfo.ResumeLayout(false);
            this.customerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox customerInfo;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Label txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}