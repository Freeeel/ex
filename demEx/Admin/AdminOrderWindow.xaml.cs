using demEx.Models;
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
using System.Windows.Shapes;

namespace demEx.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminOrderWindow.xaml
    /// </summary>
    public partial class AdminOrderWindow : Window
    {

        private List<Order> _orders = new List<Order>();
        public AdminOrderWindow()
        {
            InitializeComponent();

            _orders = new Base().ReadObjectFromFile();
            if ( _orders != null )
            {
                dataGrid.ItemsSource = _orders;
            }
            else
            {
                dataGrid.ItemsSource = new Base().GenerateOrders();
                new Base().WriteObjectToFile(new Base().GenerateOrders());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var existingOrder = (sender as Button).DataContext as Order;
            AdminAddEditOrderWindow adminAddEditOrderWindow = new AdminAddEditOrderWindow(existingOrder);
            adminAddEditOrderWindow.Show();
            this.Close();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AdminAddEditOrderWindow adminAddEditOrderWindow = new AdminAddEditOrderWindow(null);
            adminAddEditOrderWindow.Show();
            this.Close();
        }
    }
}
