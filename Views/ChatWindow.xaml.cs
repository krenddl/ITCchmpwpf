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
    /// Логика взаимодействия для ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Page
    {
        public int _chatId;
        public ChatMessage messageContext;
        public ChatWindow(Chatroom chatroom)
        {
            InitializeComponent();
            _chatId = chatroom.Id;
            LVMessages.ItemsSource = App.db.ChatMessage.Where(x=>x.Chatroom_Id==_chatId).ToList();
            messageContext = new ChatMessage();

        }
        private void LoadChatDetails()
        {
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Topic(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Send(object sender, RoutedEventArgs e)
        {

        }
    }
}
