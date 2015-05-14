using System;

namespace MyFinance.ViewModels
{
    [Serializable]
    public class TransactionViewModel : ViewModelBase
    {
        private readonly AccountViewModel _account;

        public AccountViewModel Account
        {
            get
            {
                return _account;
            }
        }

        public TransactionViewModel(AccountViewModel account, bool isEdit = false)
        {
            _account = account;
            IsEdit = isEdit;
            Account.UpdateBalance();
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                _createdDate = value;
                RaisePropertyChanged("CreatedDate");
            }
        }

        public bool IsIncome
        {
            get { return _isIncome; }
            set
            {
                _isIncome = value;
                RaisePropertyChanged("IsIncome");
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged("Description");
            }
        }

        public decimal Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                RaisePropertyChanged("Amount");
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
                RaisePropertyChanged("Balance");
            }
        }

        public Guid TransactionId
        {
            get { return _transactionId; }
            set
            {
                _transactionId = value;
                RaisePropertyChanged("TransactionId");
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

        private DateTime _createdDate;
        private bool _isIncome;
        private string _description;
        private decimal _amount;
        private decimal _balance;
        private Guid _transactionId;
        private bool _isEdit;

    }
}
