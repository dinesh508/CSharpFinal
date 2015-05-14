using System.Windows;
using MahApps.Metro.Controls.Dialogs;
using MyFinance.ViewModels;

namespace MyFinance.Views
{
    /// <summary>
    /// Interaction logic for TransactionManager.xaml
    /// </summary>
    public partial class TransactionsView
    {

        public TransactionsView(AccountViewModel acctVm)
        {
            InitializeComponent();

            DataContext = acctVm;
            //MessageBox.Show(acctVm.Transactions.Count.ToString());
        }

        private void NewTransaction(object sender, RoutedEventArgs e)
        {
            var accVm = DataContext as AccountViewModel;

            if (accVm == null)
                return;

            var newTransVm = new TransactionViewModel(accVm, false);
            var newTransWin = new TransactionsManager { DataContext = newTransVm };

            newTransWin.ShowDialog();
        }

        private void EditTransactionClicked(object sender, RoutedEventArgs e)
        {
            var accVm = DataContext as AccountViewModel;
            var transVm = ((FrameworkElement)sender).DataContext as TransactionViewModel;

            if (accVm == null || transVm == null)
                return;

            transVm.IsEdit = true;
            var editTransWin = new TransactionsManager { DataContext = transVm };

            editTransWin.ShowDialog();
        }

        private async void DeleteTransactionClicked(object sender, RoutedEventArgs e)
        {
            var transVm = ((FrameworkElement)sender).DataContext as TransactionViewModel;

            if (transVm == null)
                return;

            MetroDialogOptions.AffirmativeButtonText = "Yes, Delete";
            MetroDialogOptions.NegativeButtonText = "No, Cancel";
            var result = await this.ShowMessageAsync("My Finance",
                                                     "Do you want to delete '"
                                                     + transVm.Description + "' transaction ?",
                                                     MessageDialogStyle.AffirmativeAndNegative);

            if (result == MessageDialogResult.Affirmative)
            {
                var accVm = DataContext as AccountViewModel;

                if (accVm == null)
                    return;

                accVm.Transactions.Remove(transVm);
                accVm.UpdateBalance();
            }

            e.Handled = true;
        }
    }
}
