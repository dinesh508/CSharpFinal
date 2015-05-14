using System;
using System.Globalization;
using System.Windows.Controls;

namespace MyFinance.Core
{
    internal class BalanceValidationRule : ValidationRule
    {

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string balanceText = Convert.ToString(value);

            double balance = 0;
            if (!double.TryParse(balanceText, out balance) || balance < 0)
                return new ValidationResult(false, "Please enter a valid amount.");

            return new ValidationResult(true, null);
        }
    }
}
