namespace WindowsFormFirstLesson
{
    partial class SendMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.sendMessageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zəhmət olmasa ikinci forma \r\ngöndərmək istədiyiniz mesajı daxil edin.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(24, 81);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(319, 27);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.Text = "Mesaj daxil edin...";
            this.txtMessage.Enter += new System.EventHandler(this.myEvent);
            // 
            // sendMessageBtn
            // 
            this.sendMessageBtn.Location = new System.Drawing.Point(24, 133);
            this.sendMessageBtn.Name = "sendMessageBtn";
            this.sendMessageBtn.Size = new System.Drawing.Size(319, 50);
            this.sendMessageBtn.TabIndex = 3;
            this.sendMessageBtn.Text = "Mesajı ikinci ekrana göndərin";
            this.sendMessageBtn.UseVisualStyleBackColor = true;
            this.sendMessageBtn.Click += new System.EventHandler(this.sendMessageBtn_Click);
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.sendMessageBtn);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SendMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj göndərən form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button sendMessageBtn;
    }
}