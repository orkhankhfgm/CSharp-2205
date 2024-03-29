﻿namespace OpenFormsAndDynamicFormElements.DynamicFormElementsFolder
{
    partial class DynamicFormElements
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
            this.createNewButtonBtn = new System.Windows.Forms.Button();
            this.createNewTextBoxBtn = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // createNewButtonBtn
            // 
            this.createNewButtonBtn.Location = new System.Drawing.Point(12, 12);
            this.createNewButtonBtn.Name = "createNewButtonBtn";
            this.createNewButtonBtn.Size = new System.Drawing.Size(126, 46);
            this.createNewButtonBtn.TabIndex = 0;
            this.createNewButtonBtn.Text = "Yeni button yarat";
            this.createNewButtonBtn.UseVisualStyleBackColor = true;
            this.createNewButtonBtn.Click += new System.EventHandler(this.createNewButtonBtn_Click);
            // 
            // createNewTextBoxBtn
            // 
            this.createNewTextBoxBtn.Location = new System.Drawing.Point(144, 12);
            this.createNewTextBoxBtn.Name = "createNewTextBoxBtn";
            this.createNewTextBoxBtn.Size = new System.Drawing.Size(126, 46);
            this.createNewTextBoxBtn.TabIndex = 1;
            this.createNewTextBoxBtn.Text = "Yeni TextBox yarat";
            this.createNewTextBoxBtn.UseVisualStyleBackColor = true;
            this.createNewTextBoxBtn.Click += new System.EventHandler(this.createNewTextBoxBtn_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.AutoScroll = true;
            this.buttonsPanel.Location = new System.Drawing.Point(12, 64);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1042, 304);
            this.buttonsPanel.TabIndex = 2;
            // 
            // textBoxesPanel
            // 
            this.textBoxesPanel.AutoScroll = true;
            this.textBoxesPanel.Location = new System.Drawing.Point(12, 374);
            this.textBoxesPanel.Name = "textBoxesPanel";
            this.textBoxesPanel.Size = new System.Drawing.Size(1042, 311);
            this.textBoxesPanel.TabIndex = 3;
            // 
            // DynamicFormElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 697);
            this.Controls.Add(this.textBoxesPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.createNewTextBoxBtn);
            this.Controls.Add(this.createNewButtonBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DynamicFormElements";
            this.Text = "Dinamik Form Elementləri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNewButtonBtn;
        private System.Windows.Forms.Button createNewTextBoxBtn;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.FlowLayoutPanel textBoxesPanel;
    }
}