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
    /// Логика взаимодействия для WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Page
    {
        private List<Product> products = new List<Product>();
        public WelcomePage()
        {
            InitializeComponent();
            ListProducts.ItemsSource = AppData.db.Product.OrderBy(product => product.Title).ToList();
        }

        private void Busket_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Busket());
        }
    }
}
