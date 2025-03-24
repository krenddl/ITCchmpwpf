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
using ITCChampionship.Models;

namespace ITCChampionship.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeeFinder.xaml
    /// </summary>
    public partial class EmployeeFinder : Page
    {
        public List<Employee> employees = new List<Employee>();


        public EmployeeFinder()
        {
            InitializeComponent();

        }
        private void LoadEmployeesFromDatabase()
        {
        }
        private void SearchBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
