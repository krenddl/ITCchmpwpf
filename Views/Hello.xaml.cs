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
    /// Логика взаимодействия для Hello.xaml
    /// </summary>
    public partial class Hello : Page
    {
        public Employee ContextEmployee { get; set; }
        
        public Hello(Employee contextEmployee)
        {
            InitializeComponent();
            ContextEmployee = contextEmployee;
            Refresh();
        }
        private void Refresh()
        {
            DGName.Text = $"Hello {ContextEmployee.Name}";
            DGChat.ItemsSource = App.db.Chatroom.ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.mainwin.MainFrame.Navigate(new ChatWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeeFinder());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.mainwin.Close();
        }
    }
}
