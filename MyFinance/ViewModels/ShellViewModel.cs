using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using MyFinance.Core;

namespace MyFinance.ViewModels
{
    [Serializable]
    public class ShellViewModel : ViewModelBase
    {

        public ShellViewModel()
        {
            UserName = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["UserId"]).ToUpper();
            _accounts = new ObservableCollection<AccountViewModel>();

            _accounts.CollectionChanged += _accounts_CollectionChanged;
            
            UpdateTotals();
        }

        void _accounts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            RaisePropertyChanged("Accounts");
        }

        public ObservableCollection<AccountViewModel> Accounts
        {
            get { return _accounts; }
            set
            {
                _accounts = value;
                RaisePropertyChanged("Accounts");
                UpdateTotals();
                //RaisePropertyChanged("TotalBalance");
            }
        }

        public void UpdateTotals()
        {
            TotalBalance = Accounts.Sum(a => a.NetBalance);
            RaisePropertyChanged("TotalBalance");
        }

        public decimal TotalBalance
        {
            get
            {
                return _totalBalance;
            }
            set
            {
                _totalBalance = value;
                RaisePropertyChanged("TotalBalance");
            }
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged("UserName");
            }
        }

        private ObservableCollection<AccountViewModel> _accounts;
        private decimal _totalBalance;
        private string _userName;

    }
}
