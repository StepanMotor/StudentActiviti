using StudentActiviti.Model;
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
    /// Логика взаимодействия для AddActivity.xaml
    /// </summary>
    public partial class AddActivity : Page
    {
        List<Direction> direction = App.context.Direction.ToList();
        public AddActivity()
        {
            InitializeComponent();
            ActivityCmb.ItemsSource = direction;
            ActivityCmb.SelectedItem = "Id";
            ActivityCmb.DisplayMemberPath = "Name";
        }

        private void AddActivityBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Activity newActivity = new Activity
                { 
                    Name = ActivityTb.Text,
                    Direction = ActivityCmb.SelectedItem as Direction,
                };

                App.context.Activity.Add(newActivity);
                App.context.SaveChanges();
                MessageBox.Show("Соревнование успешно добавлено");
            }
            catch 
            {
                MessageBox.Show("Данные неверны");


            }
        }
    }
}
