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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace банкрол
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal account1Balance = 0;
        private decimal account2Balance = 0;

        public MainWindow()
        {
            InitializeComponent(); 
            UpdateAccountBalances();

        }

        private void UpdateAccountBalances()
        {
            account1Label.Content = account1Balance.ToString("C");
            account2Label.Content = account2Balance.ToString("C");
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (decimal.TryParse(amountTextBox.Text, out decimal amount))
                {
                    account1Balance += amount;
                    UpdateAccountBalances();
                    amountTextBox.Text = "";

                    // Добавляем сумму пополнения в список
                    AddTransactionToList($"Пополнение: {amount.ToString("C")} - {DateTime.Now.ToString()}");
                }
                else
                {
                    MessageBox.Show("Введите корректную сумму.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при пополнении счетов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                if (decimal.TryParse(сумма.Text, out decimal amount))
                {
                    if (account1Balance >= amount)
                    {
                        account1Balance -= amount;
                        account2Balance += amount;
                        UpdateAccountBalances();
                        сумма.Text = "";

                      
                        AddTransactionToList($"Перевод: {amount.ToString("C")} - {DateTime.Now.ToString()}");
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно средств на первом счете.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректную сумму для перевода.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при переводе средств: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddTransactionToList(string transactionDetails)
        {
            ListBoxItem newItem = new ListBoxItem();
            newItem.Content = transactionDetails;
            transactionListBox.Items.Add(newItem);
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sq.Visibility = Visibility;
            aq.Visibility = Visibility;
            qa.Visibility = Visibility;
            aaa.Visibility = Visibility;
            bb.Visibility = Visibility.Collapsed;
        }



        private void aq_Checked_1(object sender, RoutedEventArgs e)
        {
            if (aq.IsChecked == true)
            {
                amountTextBox.Visibility = Visibility;
                ww.Visibility = Visibility;
                сумма.Visibility = Visibility.Collapsed;
                ee.Visibility = Visibility.Collapsed;
                transactionListBox.Visibility = Visibility.Collapsed;
            }
            else if (qa.IsChecked == true)
            {
                amountTextBox.Visibility = Visibility.Collapsed;
                ww.Visibility = Visibility.Collapsed;
                сумма.Visibility = Visibility;
                ee.Visibility = Visibility;
                transactionListBox.Visibility = Visibility.Collapsed;
            }
            else if (sq.IsChecked == true)
            {
                transactionListBox.Visibility = Visibility;
                amountTextBox.Visibility = Visibility.Collapsed;
                ww.Visibility = Visibility.Collapsed;
                сумма.Visibility = Visibility.Collapsed;
                ee.Visibility = Visibility.Collapsed;
            }
        }

        private void aaa_Click(object sender, RoutedEventArgs e)
        {

            sq.Visibility = Visibility.Collapsed;
            aq.Visibility = Visibility.Collapsed;
            qa.Visibility = Visibility.Collapsed;
            aaa.Visibility = Visibility.Collapsed;
            bb.Visibility = Visibility;
            amountTextBox.Visibility = Visibility.Collapsed;
            ww.Visibility = Visibility.Collapsed;
            сумма.Visibility = Visibility.Collapsed;
            ee.Visibility = Visibility.Collapsed;

        }

        











    }
}
