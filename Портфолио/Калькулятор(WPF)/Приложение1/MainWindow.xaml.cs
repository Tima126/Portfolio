using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Приложение1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private ObservableCollection<double> data = new ObservableCollection<double>();

        private void считать__Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(число_.Text) && (string.IsNullOrWhiteSpace(Число2.Text)))
            {
                MessageBox.Show("пустая строка");

            }
            else if (string.IsNullOrWhiteSpace(Число2.Text)&& (string.IsNullOrWhiteSpace(Число3.Text)))
            {
                
                MessageBox.Show("пустая строка");

            }
            else if (string.IsNullOrWhiteSpace(число_.Text) && (string.IsNullOrWhiteSpace(Число3.Text)))
            {

                MessageBox.Show("пустая строка");

            }
            else if (string.IsNullOrWhiteSpace(число_.Text))
            {
                double num2 = Convert.ToDouble(Число2.Text);
                double num3 = Convert.ToDouble(Число3.Text);
                double result = 0;

                if (radioButtan1.IsChecked == true)
                {
                    result = num2 + num3;
                }
                else if (radioButtan2.IsChecked == true)
                {
                    result = num2 - num3;
                }
                else if (radioButtan3.IsChecked == true)
                {
                    result = num2 * num3;
                }
                else if (radioButtan4.IsChecked == true)
                {
                    if (num2 != 0 && num3 == 0)
                    {
                       
                        MessageBox.Show("Делить на ноль нельзя иди учи матан");
                    }
                    else
                    {
                        result = num2 / num3;
                    }
                }
                
                
                data.Add(result);
                List.ItemsSource = data;
                

            }
            else if (string.IsNullOrWhiteSpace(Число2.Text))
            {
                double num1 = Convert.ToDouble(число_.Text);
                double num3 = Convert.ToDouble(Число3.Text);
                double result = 0;

                if (radioButtan1.IsChecked == true)
                {
                    result = num1 + num3;
                }
                else if (radioButtan2.IsChecked == true)
                {
                    result = num1 - num3;
                }
                else if (radioButtan3.IsChecked == true)
                {
                    result = num1 * num3;
                }
                else if (radioButtan4.IsChecked == true)
                {
                    if (num1 != 0 && num3 == 0)
                    {

                        MessageBox.Show("Делить на ноль нельзя иди учи матан");
                    }
                    else
                    {
                        result = num1 / num3;
                    }
                }
                data.Add(result);
                List.ItemsSource = data;
            }

            else if ((string.IsNullOrWhiteSpace(Число3.Text)))
            {
                double num2 = Convert.ToDouble(Число2.Text);
                double num1 = Convert.ToDouble(число_.Text);
                double result = 0;

                if (radioButtan1.IsChecked == true)
                {
                    result = num2 + num1;
                }
                else if (radioButtan2.IsChecked == true)
                {
                    result = num2 - num1;
                }
                else if (radioButtan3.IsChecked == true)
                {
                    result = num2 * num1;
                }
                else if (radioButtan4.IsChecked == true)
                {
                    if (num2 != 0 && num1 == 0)
                    {

                        MessageBox.Show("Делить на ноль нельзя иди учи матан");
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                }
                data.Add(result);
                List.ItemsSource = data;

            }
            else
            {
                double num3 = Convert.ToDouble(Число3.Text);
                double num2 = Convert.ToDouble(Число2.Text);
                double num1 = Convert.ToDouble(число_.Text);
                double result = 0;

                if (radioButtan1.IsChecked == true)
                {
                    result = num2 + num3 + num1;
                }
                else if (radioButtan2.IsChecked == true)
                {
                    result = num2 - num3 - num1;
                }
                else if (radioButtan3.IsChecked == true)
                {
                    result = num2 * num3 * num1;
                }
                else if (radioButtan4.IsChecked == true)
                {
                    if (num2 != 0 && num3 == 0 && num1 == 0 || num2 == 0 && num3 != 0 && num1 == 0 || num2 == 0 && num3 == 0 && num1 != 0)
                    {

                        MessageBox.Show("Делить на ноль нельзя иди учи матан");
                    }
                    else
                    {
                        result = num2 / num3;
                    }
                }
                data.Add(result);
                List.ItemsSource = data;
            }
        }
        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Тема_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int color = Тема.SelectedIndex;

            switch(color)
            {
                case 0:
                Program.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E0619A"));
                    break; 
                case 1:
                    Program.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                    break;
                case 2:
                    Program.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3e30dc"));
                    break;
                case 3:
                    Program.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90E265"));
                    break;
                case 4:
                    Program.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));
                    break;


            }
        }

        private void Clin_Click(object sender, RoutedEventArgs e)
        {
            data.Clear();
            List.Items.Refresh();
        }

        private void Savefile_Click(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            path += @"\number.txt";
            MessageBox.Show("Файл сохранён по пути:"+ path);
            File.Exists(path);
            File.WriteAllText(path, Convert.ToString(List));
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in List.Items)
                {
                    sw.WriteLine(item.ToString());
                }

            }
            MessageBox.Show("Файл сохранён по пути:" + path);
        }


    }
}
