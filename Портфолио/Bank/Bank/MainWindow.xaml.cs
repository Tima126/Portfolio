using System;
using System.Collections.Generic;
using System.IO;
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

namespace Bank
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateBalance();
          
        }
       
        private double balance = 0;
        private double balanceOtpravitil = 0;

        private void пополнитьButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TB.Text, out double amount))
            {
                // Проверка успешного преобразования введенной суммы
                balance += amount; // Увеличение баланса на введенную сумму
                UpdateBalance(); // Обновление отображения баланса
                TB.Clear(); // Очистка поля ввода суммы
                AddTransactionToList($"Пополнение: {amount.ToString("C")} - {DateTime.Now.ToString()}");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректную сумму.", "Ошибка");
            }
        }

        private void переводButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TB.Text, out double amount) && amount >= 0)
            {
                if (balanceOtpravitil >= amount)
                {
                    balanceOtpravitil -= amount;
                    balance += amount;
                    UpdateBalance();
                    TB.Text = "";
                    MessageBox.Show($"Средства в размере {amount} успешно переведены. Баланс отправителя: {balanceOtpravitil}");
                    AddTransactionToList($"Перевод: {amount.ToString("C")} - {DateTime.Now.ToString()}");
                }
                else
                {
                    MessageBox.Show($"Недостаточно средств на счете для перевода. Баланс отправителя: {balanceOtpravitil}");
                }
            }
            else
            {
                MessageBox.Show("Введите корректную сумму для снятия.");
            }
        }
        private void AddTransactionToList(string transactionDetails)
        {
            ListBoxItem newItem = new ListBoxItem();
            newItem.Content = transactionDetails;
            transactionListBox.Items.Add(newItem);
        }
        private void UpdateBalance()
        {
            выводLB.Content = balanceOtpravitil;
        }

        private void Тема_Click(object sender, RoutedEventArgs e)
        {
            Tema tema = new Tema(this);
            tema.Show();
        }

        
    }

   

}

