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

namespace StudentActiviti
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

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.Pages.AddGroup());
        }

        private void AddActivityBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.Pages.AddActivity());

        }

        private void AccountingBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.Pages.Accounting());

        }

        private void ReportBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Report2Btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
