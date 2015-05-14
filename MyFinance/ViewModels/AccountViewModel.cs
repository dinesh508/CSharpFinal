using System;
using MyFinance.Core;
using System.Collections.ObjectModel;
using System.Linq;

namespace MyFinance.ViewModels
{
    [Serializable]
    public class AccountViewModel : ViewModelBase
    {
        private readonly ShellViewModel _shellVm;

        public ShellViewModel Shell
        {
            get
            {
                return _shellVm;
            }
        }

        public AccountViewModel(ShellViewModel shellVm, bool isEdit = false)
        {
            _shellVm = shellVm;
            IsEdit = isEdit;

            if (Transactions == null)
                Transactions = new ObservableCollection<TransactionViewModel>();

            UpdateBalance();
        }

        public Guid AccountId
        {
            get { return _accountId; }
            set
            {
                _accountId = value;
                RaisePropertyChanged("AccountId");
            }
        }

        public string AccountName
        {
            get { return _accountName; }
            set
            {
                _accountName = value;
                RaisePropertyChanged("AccountName");
            }
        }

        public bool IsSavings
        {
            get { return _isSavings; }
            set
            {
                _isSavings = value;
                RaisePropertyChanged("IsSavings");
            }
        }

        public string PayeeName
        {
            get { return _payeeName; }
            set
            {
                _payeeName = value;
                RaisePropertyChanged("PayeeName");
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
                RaisePropertyChanged("Balance");
                UpdateBalance();
            }
        }

        public bool IsEdit
        {
            get { return _isEdit; }
            set
            {
                _isEdit = value;
                RaisePropertyChanged("IsEdit");
            }
        }

        public ObservableCollection<TransactionViewModel> Transactions
        {
            get { return _transactions; }
            set
            {
                _transactions = value;
                RaisePropertyChanged("Transactions");
            }
        }

        public decimal NetBalance
        {
            get { return _netBalance; }
            set
            {
                _netBalance = value;
                RaisePropertyChanged("NetBalance");
                Shell.UpdateTotals();
            }
        }

        private Guid _accountId;
        private string _accountName;
        private bool _isSavings;
        private string _payeeName;
        private decimal _balance;
        private decimal _netBalance;
        private bool _isEdit;
        private ObservableCollection<TransactionViewModel> _transactions;

        public void UpdateBalance()
        {
            //Net Balance = Opening Balance + Income - Expenses
            NetBalance = Balance
                        + Transactions.Where(t => t.IsIncome).Sum(t => t.Amount)
                        - Transactions.Where(t => !t.IsIncome).Sum(t => t.Amount);
        }
    }
}
