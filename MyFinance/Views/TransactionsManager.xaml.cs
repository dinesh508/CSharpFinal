using System;
using System.Collections.Generic;
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
using MyFinance.ViewModels;

namespace MyFinance.Views
{
    /// <summary>
    /// Interaction logic for TransactionsManager.xaml
    /// </summary>
    public partial class TransactionsManager
    {
        public TransactionsManager()
        {
            
            InitializeComponent();
            this.Background = System.Windows.Media.Brushes.Red;
            
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            var transVm = DataContext as TransactionViewModel;
            if (transVm == null)
            {
                DialogResult = false;
                Close();
                return;
            }

            if (string.IsNullOrWhiteSpace(transVm.Description))
            {
                this.ShowMessageAsync("My Finance", "Please provide transaction description.");
                return;
            }

            if (transVm.Balance < 0)
            {
                this.ShowMessageAsync("My Finance", "Please provide a positive amount value.");
                return;
            }

            if (!IsValid(this))
            {
                return;
            }

            if (!transVm.IsEdit)
            {
                transVm.TransactionId = Guid.NewGuid();
                transVm.CreatedDate = DateTime.Now;
                transVm.Account.Transactions.Add(transVm);
            }

            transVm.Account.UpdateBalance();

            Close();
        }

        private bool IsValid(DependencyObject obj)
        {
            return !Validation.GetHasError(obj)
                   && LogicalTreeHelper.GetChildren(obj).OfType<DependencyObject>().All(IsValid);
        }
    }
}
