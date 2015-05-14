using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using MahApps.Metro.Controls.Dialogs;
using MyFinance.ViewModels;
using MyFinance.Views;
using System.Windows.Media;

namespace MyFinance
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell
    {
        private const string SaveFile = "Data.bin";

        public Shell()
        {
            InitializeComponent();
            LoadData();
            Closing += Shell_Closing;
            MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;
        }

        private void LoadData()
        {
            try
            {
                if (!File.Exists(SaveFile))
                    return;

                var shellVm = DataContext as ShellViewModel;
                var objectData = File.ReadAllText(SaveFile);
                var vm = DeserializeFromString<ShellViewModel>(objectData);

                if (vm != null && shellVm != null)
                {
                    shellVm.Accounts = vm.Accounts ?? new ObservableCollection<AccountViewModel>();
                    shellVm.UpdateTotals();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        void Shell_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var shellVm = DataContext as ShellViewModel;

            if (shellVm == null)
                return;

            try
            {
                var objectData = SerializeToString(shellVm);
                File.WriteAllText(SaveFile, objectData);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private static TData DeserializeFromString<TData>(string settings)
        {
            var b = Convert.FromBase64String(settings);
            using (var stream = new MemoryStream(b))
            {
                var formatter = new BinaryFormatter();
                stream.Seek(0, SeekOrigin.Begin);
                return (TData)formatter.Deserialize(stream);
            }
        }

        private static string SerializeToString<TData>(TData settings)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, settings);
                stream.Flush();
                stream.Position = 0;
                return Convert.ToBase64String(stream.ToArray());
            }
        }

        void AboutClicked(object sender, RoutedEventArgs e)
        {
            AboutFlyout.IsOpen = !AboutFlyout.IsOpen;
        }

        private void NewAccountOnClicked(object sender, RoutedEventArgs e)
        {
            var shellVm = DataContext as ShellViewModel;

            if (shellVm == null)
                return;

            var mgr = new AccountManager();
            var vm = new AccountViewModel(shellVm);

            mgr.DataContext = vm;

            mgr.ShowDialog();
        }

        private async void DeleteClicked(object sender, RoutedEventArgs e)
        {
            var accVm = ((FrameworkElement)sender).DataContext as AccountViewModel;

            if (accVm != null)
            {
                MetroDialogOptions.AffirmativeButtonText = "Yes, Delete";
                MetroDialogOptions.NegativeButtonText = "No, Cancel";
                var result = await this.ShowMessageAsync("My Finance", "Do you want to delete '" + accVm.AccountName + "' ?", MessageDialogStyle.AffirmativeAndNegative);

                if (result == MessageDialogResult.Affirmative)
                {
                    var shellVm = DataContext as ShellViewModel;

                    if (shellVm == null)
                        return;

                    shellVm.Accounts.Remove(accVm);
                    shellVm.UpdateTotals();
                }
            }

            e.Handled = true;
        }

        private void TransactionClicked(object sender, RoutedEventArgs e)
        {
            //TransactionsView.BackgroundProperty = System.Windows.Media.Brushes.Red;
            var accVm = ((FrameworkElement)sender).DataContext as AccountViewModel;

            if (accVm != null)
            {
                if (accVm.Transactions == null)
                    accVm.Transactions = new ObservableCollection<TransactionViewModel>();

                var transWin = new TransactionsView(accVm);
                transWin.ShowDialog();
            }
            e.Handled = true;
        }

        private void EditClicked(object sender, RoutedEventArgs e)
        {
            var accVm = ((FrameworkElement)sender).DataContext as AccountViewModel;

            if (accVm != null)
            {
                var mgr = new AccountManager();
                accVm.IsEdit = true;

                mgr.DataContext = accVm;

                mgr.ShowDialog();
            }
            e.Handled = true;
        }

        private void ChartsClicked(object sender, RoutedEventArgs e)
        {
            var shellVm = DataContext as ShellViewModel;

            if (shellVm == null)
                return;

            var chartView = new ChartView() { DataContext = shellVm };
            chartView.ShowDialog();
        }
    }
}