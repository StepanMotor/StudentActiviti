using StudentActiviti.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Group = StudentActiviti.Model.Group;

namespace StudentActiviti.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Accounting.xaml
    /// </summary>
    public partial class Accounting : Page
    {
        List<Journal> journals = App.context.Journal.ToList();
        List<Activity> activities = App.context.Activity.ToList();
        List<Special> specials = App.context.Special.ToList();
        List<Group> groups = App.context.Group.ToList();
        List<Direction> directions = App.context.Direction.ToList();
        public Accounting()
        {
            InitializeComponent();
            GroupLv.ItemsSource = journals;

            SelectChoiceCmb.ItemsSource = specials;
            SelectChoiceCmb.SelectedItem = "Id";
            SelectChoiceCmb.DisplayMemberPath = "Name";

            SelectGroupCmb.ItemsSource = groups;
            SelectGroupCmb.SelectedItem = "Id";
            SelectGroupCmb.DisplayMemberPath = "Name";

            SelectStatusCmb.ItemsSource = directions;
            SelectStatusCmb.SelectedItem = "Id";
            SelectStatusCmb.DisplayMemberPath = "Name";

            SelectActivityCmb.ItemsSource = activities;
            SelectActivityCmb.SelectedItem = "Id";
            SelectActivityCmb.DisplayMemberPath = "Name";
        }

        private void AddActivityBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Journal newJournal = new Journal
                {
                    DateEvent = (DateTime)ChoiceDateDp.SelectedDate,
                    Group = SelectGroupCmb.SelectedItem as Group,
                    Activity = SelectActivityCmb.SelectedItem as Activity,
                    Mark = Convert.ToDecimal(MarkTb.Text),

                };

                App.context.Journal.Add(newJournal);
                App.context.SaveChanges();
                MessageBox.Show("Соревнование успешно добавлено");
                GroupLv.ItemsSource = journals;
            }
            catch
            {
                MessageBox.Show("Данные неверны");


            }
        }

        private void SelectChoiceCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedGS = Convert.ToInt32(SelectChoiceCmb.SelectedItem);
            SelectGroupCmb.ItemsSource = App.context.Group.Where(x => x.Id == SelectedGS).ToList();
        }

        private void SelectStatusCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    }


