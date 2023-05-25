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
using Test.Models;

namespace Test.Views
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            // Заполенение комбобокса
            CmbRole.ItemsSource = AppData.db.Role.ToList();
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            User people = new User();
            people.Login = TxbLogin.Text;
            people.Password = TxbPassword.Text;

            var CurrentRole = CmbRole.SelectedItem as Role;
            people.RoleID = CurrentRole.ID;

            AppData.db.User.Add(people);
            AppData.db.SaveChanges();
            NavigationService.Navigate(new SignInPage());
        }
    }
}
