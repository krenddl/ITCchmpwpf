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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public Employee ContextEmployee { get; set; }
        public Chatroom ChatroomContext {  get; set; }

        public LoginPage()
        {
            InitializeComponent();
            ContextEmployee = new Employee();
            this.Loaded += Login_Load;
        }
        

        private void Button_Ok(object sender, RoutedEventArgs e)
        {
            var username = Username.Text;
            var password = Password.Text;
            if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                return;
            }
            else
            {
                if (Chkbox.IsChecked == true) 
                { 
                    Properties.Settings.Default.username = username;
                    Properties.Settings.Default.password = password;
                    Properties.Settings.Default.Save();
                }
               
                    ContextEmployee = App.db.Employee.FirstOrDefault(p => p.Username == username && p.Password == password);
                    if (ContextEmployee != null)
                    {
                        NavigationService.Navigate(new Hello(ContextEmployee));
                    }
                    else
                    {
                        return;
                    }
                

            }
        }
        private void Login_Load(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                Username.Text = Properties.Settings.Default.username;
                Password.Text = Properties.Settings.Default.password;
            }
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            App.mainwin.Close();
        }
    }
}
