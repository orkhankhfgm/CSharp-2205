using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppPart5
{
    public partial class MultipleListBoxResultView : Form
    {
        public MultipleListBoxResultView(List<Book> books)
        {
            InitializeComponent();

            foreach (var item in books)
            {
                var x = item;
            }
        }
    }
}
