using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFormsAndDynamicFormElements
{
    public partial class VerifyPersonData : Form
    {
        public VerifyPersonData()
        {
            InitializeComponent();
        }

        private void cancellFormBtn_Click(object sender, EventArgs e)
        {
            Form currentForm = this;

            foreach (Control formItem in currentForm.Controls)
            {
                if (formItem is TextBox)
                    ((TextBox)formItem).Text = string.Empty;
            }
            currentForm.Close();
        }

        private void submitFormBtn_Click(object sender, EventArgs e)
        {
            Form currentForm = this;

            foreach (Form item in Application.OpenForms)
            {
                if(item is AddPerson){ //item.Name == "AddPerson"

                    foreach (Control formItem in item.Controls)
                    {
                        if (formItem is TextBox)
                            ((TextBox)formItem).Text = string.Empty;
                    }

                }
            }

            Form addPersonForm = Application.OpenForms["AddPerson"];

            currentForm.Close();
        }
    }
}
