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
    /// Логика взаимодействия для AddGroup.xaml
    /// </summary>
    public partial class AddGroup : Page
    {
        List<Special> specials = App.context.Special.ToList();
        public AddGroup()
        {
            InitializeComponent();
            SpecialCmb.ItemsSource = specials;
            SpecialCmb.SelectedItem = "Id";
            SpecialCmb.DisplayMemberPath = "Name";

        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Group newGroup = new Group()
                {
                    Name = GroupTb.Text,
                    Special = SpecialCmb.SelectedItem as Special
                };

                App.context.Group.Add(newGroup);
                App.context.SaveChanges();
                MessageBox.Show("Группа успешно добавлена");
            }
            catch
            {
                MessageBox.Show("Данные неверны");


            }
        }
    }
}
