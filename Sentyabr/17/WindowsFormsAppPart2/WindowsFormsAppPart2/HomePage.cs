using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsAppPart2
{
    public partial class HomePage : Form
    {
        public HomePage(User user)
        {
            InitializeComponent();

            nameEdit.Text = user.Name;
            surnameEdit.Text = user.Surname;
            usernameEdit.Text = user.Username;
            passwordEdit.Text = user.Password;
            aboutUserEdit.Text = user.AboutUser;
            saveUserInfoBtn.Tag = user.Id;
        }

        private void saveUserInfoBtn_Click(object sender, System.EventArgs e)
        {
            bool closeEditForm = false;

            var userId = (int)((Button)sender).Tag;

            var user = VirtualDatabase.Users.FirstOrDefault(m => m.Id == userId);

            user.Name = nameEdit.Text;
            user.Surname = surnameEdit.Text;

            if(user.Password != passwordEdit.Text)
            {
                closeEditForm = true;
            }

            user.Password = passwordEdit.Text;
            user.AboutUser = aboutUserEdit.Text;

            if (closeEditForm)
                Close();
        }
    }
}
