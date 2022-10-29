using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart6
{
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm()
        {
            InitializeComponent();
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            VirtualDatabase db = new VirtualDatabase();
            List<Customer> customers = db.GetCustomers(100);

            customersDataGridView.DataSource = customers;
            customersDataGridView.Columns[0].Width = 25;
            customersDataGridView.Columns["Name"].HeaderText = "Ad";
            customersDataGridView.Columns["Fullname"].Visible = false;

            //Linq select 1-ci yol.
            var queryResult = (from item in customers
                               select new //anonymous type
                               {
                                   Sira = item.Id,
                                   Ad = item.Name,
                                   Soyad = item.Surname
                               }).ToList();

            //Linq select 2-ci yol. (method ile)
            var queryResult2 = customers.Select(item => new
            { //also anonymous type
                Id = item.Id,
                Ad = item.Name,
                Soyad = item.Surname
            })
            .ToList();

            customersDataGridView.DataSource = queryResult2;

            customersDataGridView.DataSource = customers;
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = customersDataGridView.CurrentCell.RowIndex;
            int customerId = (int)customersDataGridView[0, rowIndex].Value;

            VirtualDatabase db = new VirtualDatabase();
            Customer selectedCustomer = ((List<Customer>)customersDataGridView.DataSource)
                .FindAll(i => i.Id == customerId)
                .FirstOrDefault();

            /*
             Task in Lesson:
             Müştərinin məlumatlarını popup kimi açılan bir form içərisində göstərin. Ancaq From'un FormBorderStyle property'si
             None olmalıdır. Form'un bu property dəyəri none olduğuna görə artıq user onu bağlaya bilməyəcək. İndi həm yeni bir popup
             pəncərəsində seçilən müştəri məlumatları göstərilməlidir həm də user o form'u necəsə bağlaya bilməlidir
             (ALT + F4 ilə bağlamaq sayılmır :) biraz düşünün).
             Məlumatları sadəcə Label elementi içərisində göstərmək kifayətdir.
             */

            CustomerInfoPopup infoPopup = new CustomerInfoPopup(selectedCustomer);
            infoPopup.ShowDialog();
        }
    }
}
