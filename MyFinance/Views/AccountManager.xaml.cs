using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls.Dialogs;
using MyFinance.ViewModels;

namespace MyFinance.Views
{
    /// <summary>
    /// Interaction logic for AccountManager.xaml
    /// </summary>
    public partial class AccountManager
    {
        public AccountManager()
        {
            InitializeComponent();
            MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            var accountVm = DataContext as AccountViewModel;
            if (accountVm == null)
            {
                DialogResult = false;
                Close();
                return;
            }

            if (string.IsNullOrWhiteSpace(accountVm.AccountName))
            {
                this.ShowMessageAsync("My Finance", "Please provide Account Name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(accountVm.PayeeName))
            {
                this.ShowMessageAsync("My Finance", "Please provide Payee Name.");
                return;
            }

            if (accountVm.Balance < 0)
            {
                this.ShowMessageAsync("My Finance", "Please provide a positive Balance amount.");
                return;
            }

            if (!IsValid(this))
            {
                return;
            }


            if (!accountVm.IsEdit)
            {
                accountVm.AccountId = Guid.NewGuid();
                accountVm.Shell.Accounts.Add(accountVm);
                //accountVm.Shell.UpdateTotals();
            }

            accountVm.UpdateBalance();


            Close();

        }

        private bool IsValid(DependencyObject obj)
        {
            return !Validation.GetHasError(obj)
                   && LogicalTreeHelper.GetChildren(obj).OfType<DependencyObject>().All(IsValid);
        }
    }
}
