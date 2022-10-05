using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFormsAndDynamicFormElements.DynamicFormElementsFolder
{
    public partial class DynamicFormElements : Form
    {
        public DynamicFormElements()
        {
            InitializeComponent();
        }

        private void createNewButtonBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 50; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new Size(35, 35);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;

                btnTemp.Click += ShowButtonContent;
                buttonsPanel.Controls.Add(btnTemp);
            }
        }

        private void createNewTextBoxBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 30; i++)
            {
                TextBox textBoxTemp = new TextBox();
                textBoxTemp.Text = "Some text " + i.ToString();
                textBoxTemp.Size = new Size(120, 35);
                textBoxesPanel.Controls.Add(textBoxTemp);
            }
        }

        private void ShowButtonContent(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            MessageBox.Show("Click olunan button: " + text);
        }
    }
}
