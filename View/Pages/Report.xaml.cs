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

namespace StudentActiviti.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Report.xaml
    /// </summary>
    public partial class Report : Page
    {
        public Report()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {
            var a = (DateTime)StartPeriodDp.SelectedDate;
            var b = (DateTime)EndPeriodDp.SelectedDate;

            //var qwerty = App.context.Where(x => x.DateDelivery >= a && x.DateDelivery <= b).GroupBy(y => y.Name).Select(g => new { })

        }
    }
}
