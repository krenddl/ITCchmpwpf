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
            DepartmentList.ItemsSource = App.db.Department.ToList();
            Refresh();

        }
        //private void Refresh()
        //{
        //    var selectedDepartments = DepartmentList.SelectedItems
        //         .Cast<object>()
        //         .Select(item => (item as ListBoxItem)?.Content.ToString())
        //         .Where(dept => dept != null)
        //         .ToList();

        //    var filteredEmployees = employees
        //       .Where(emp => (selectedDepartments.Count == 0 || selectedDepartments.Contains(emp.Department.Name)) &&
        //                     (string.IsNullOrEmpty(TBSearch.Text) || emp.Department.Name.Contains(TBSearch.Text, StringComparison.OrdinalIgnoreCase)))
        //       .ToList();
        //    LBEmployee.ItemsSource = filteredEmployees;

        //}
        public void SetupEmployeeView()
        {
        }

        public void Refresh()
        {
            employees = App.db.Employee.ToList();
            LBEmployee.ItemsSource = employees;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();

        }

        private void DepartmentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
        List<int> selectedDepartmentIds = DepartmentList.SelectedItems
        .Cast<Department>()
        .Select(department => department.Id)
        .ToList();

            if (selectedDepartmentIds.Count > 0)
            {
                employees = App.db.Employee.Where(emp => selectedDepartmentIds.Contains(emp.Department_Id)).ToList();
            }
            else
            {
                Refresh();
            }
            if (!string.IsNullOrWhiteSpace(TBSearch.Text))
                employees = employees.Where(x => x.Name.Contains(TBSearch.Text)).ToList();

            LBEmployee.ItemsSource = employees;
        }
    }
}