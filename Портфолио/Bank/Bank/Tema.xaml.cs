using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace Bank
{
    /// <summary>
    /// Логика взаимодействия для Tema.xaml
    /// </summary>
    public partial class Tema : Window
    {
        private MainWindow _mainWindow;

        public Tema(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

 

        private void LightThemeButton_Click(object sender, RoutedEventArgs e)
        {
            var darkTheme = new ResourceDictionary { Source = new Uri("Белый.xaml", UriKind.Relative) };
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(darkTheme);
        }

        private void DarkThemeButton_Click(object sender, RoutedEventArgs e)
        {
            var darkTheme = new ResourceDictionary { Source = new Uri("Dictionary1.xaml", UriKind.Relative) };
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(darkTheme);
        }

        private void Желтый_Click(object sender, RoutedEventArgs e)
        {
            var darkTheme = new ResourceDictionary { Source = new Uri("Желтый.xaml", UriKind.Relative) };
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(darkTheme);
        }
    }
}
