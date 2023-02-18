namespace RSS___Reader_App
{
    partial class RssReader
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.btnFetch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxNews = new System.Windows.Forms.ListBox();
            this.Newsgrbbx = new System.Windows.Forms.GroupBox();
            this.newsBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Newsgrbbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFetch);
            this.groupBox1.Controls.Add(this.txtBoxUrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1490, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS Url";
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(6, 17);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(1397, 20);
            this.txtBoxUrl.TabIndex = 0;
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(1409, 15);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxNews);
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 762);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "News List";
            // 
            // listBoxNews
            // 
            this.listBoxNews.FormattingEnabled = true;
            this.listBoxNews.Location = new System.Drawing.Point(6, 19);
            this.listBoxNews.Name = "listBoxNews";
            this.listBoxNews.Size = new System.Drawing.Size(336, 732);
            this.listBoxNews.TabIndex = 0;
            this.listBoxNews.SelectedIndexChanged += new System.EventHandler(this.listBoxNews_SelectedIndexChanged);
            // 
            // Newsgrbbx
            // 
            this.Newsgrbbx.Controls.Add(this.newsBrowser);
            this.Newsgrbbx.Location = new System.Drawing.Point(366, 62);
            this.Newsgrbbx.Name = "Newsgrbbx";
            this.Newsgrbbx.Size = new System.Drawing.Size(1136, 762);
            this.Newsgrbbx.TabIndex = 2;
            this.Newsgrbbx.TabStop = false;
            this.Newsgrbbx.Text = "News";
            // 
            // newsBrowser
            // 
            this.newsBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsBrowser.Location = new System.Drawing.Point(3, 16);
            this.newsBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.newsBrowser.Name = "newsBrowser";
            this.newsBrowser.Size = new System.Drawing.Size(1130, 743);
            this.newsBrowser.TabIndex = 0;
            // 
            // RssReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 836);
            this.Controls.Add(this.Newsgrbbx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RssReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS Reader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Newsgrbbx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxNews;
        private System.Windows.Forms.GroupBox Newsgrbbx;
        private System.Windows.Forms.WebBrowser newsBrowser;
    }
}

