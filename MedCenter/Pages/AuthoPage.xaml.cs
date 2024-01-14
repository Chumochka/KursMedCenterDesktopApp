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
using MedCenter.Models;
using Newtonsoft.Json;

namespace MedCenter.Pages
{
    public partial class AuthoPage : Page
    {
        public AuthoPage()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль", "",MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            try
            {
                string response = new fetchData().GetRequest("workerautho?login=" + tbLogin.Text + "&password=" + tbPassword.Text);
                if (response.Equals("null"))
                {
                    MessageBox.Show("Некорректный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                Worker user = new Worker();
                JsonConvert.PopulateObject(response, user);
                NavigationService.Navigate(new AppointmentsPage(user));
            }catch
            {
                MessageBox.Show("Не получилось авторизоваться в системе.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
