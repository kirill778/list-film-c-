using System.Windows;
using System.Windows.Controls;

namespace FilmsListWPF.Login
{
    /// <summary>
    /// Interaction logic for Page.xaml
    /// </summary>
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e){
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            checkUser(email, password);
        }
        
        private void checkUser(string email, string password){
            if (email == "admin" && password == "1234"){
                MessageBox.Show("Login successful!");
            }
            else{
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}