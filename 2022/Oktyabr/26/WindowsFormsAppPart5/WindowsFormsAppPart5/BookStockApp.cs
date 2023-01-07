using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppPart5
{
    public partial class BookStockApp : Form
    {
        public BookStockApp()
        {
            InitializeComponent();
        }

        private void BookStockApp_Load(object sender, EventArgs e)
        {
            //FillComboboxV1();
            FillComboboxV2();
        }

        void FillComboboxV1()
        {
            foreach (var item in VirtualDatabase.BooksTable)
            {
                cmbBooks.Items.Add(item);
            }
        }

        void FillComboboxV2()
        {
            cmbBooks.DataSource = VirtualDatabase.BooksTable;
        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1-ci yol (casting ile)
            object o1 = cmbBooks.SelectedItem;
            Book book = (Book)o1;

            //2-ci yol AS ile
            book = cmbBooks.SelectedItem as Book;

            //2-ci yol AS with nullable check
            book = cmbBooks.SelectedItem == null ? null : cmbBooks.SelectedItem as Book;

            //3-cu yol (sender'i ComboBox kimi alib ComboBox'dan SelectedItem'i almaq)
            ComboBox selectedComboBox = sender as ComboBox;
            book = selectedComboBox.SelectedItem == null ? null : selectedComboBox.SelectedItem as Book;

            bookNameText.Text = book.Name;
            bookCategoryText.Text = book.Category;
            bookCountText.Text = book.Count.ToString();
            bookAuthorText.Text = book.Author;
            bookDescription.Text = book.Description;

            bookPicture.Image = Image.FromFile(book.ImagePath);
            bookPicture.SizeMode = PictureBoxSizeMode.StretchImage;

            var selectedIndex = selectedComboBox.SelectedIndex;
        }
    }
}
