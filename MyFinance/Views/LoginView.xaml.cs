using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls.Dialogs;

namespace MyFinance.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginClicked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUserName.Text))
            {
                this.ShowMessageAsync("MY FINANCE", "Please enter your Username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtPassword.Password))
            {
                this.ShowMessageAsync("MY FINANCE", "Please enter your Password.");
                return;
            }

            if (!IsValidLogin(TxtUserName.Text.Trim(), TxtPassword.Password.Trim()))
            {
                this.ShowMessageAsync("MY FINANCE", "Please provide valid credentials to proceed.");
                return;
            }

            var mainWin = new Shell();
            mainWin.Show();
            this.Close();
        }

        private bool IsValidLogin(string userId, string password)
        {
            var user = Convert.ToString(ConfigurationManager.AppSettings["UserId"]);
            var pass = Convert.ToString(ConfigurationManager.AppSettings["Pwd"]);

            return String.Compare(userId, user, StringComparison.OrdinalIgnoreCase) == 0 &&
                   String.Compare(password, pass, StringComparison.OrdinalIgnoreCase) == 0;
        }
    }
}
