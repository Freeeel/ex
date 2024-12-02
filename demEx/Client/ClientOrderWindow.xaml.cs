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

namespace demEx
{
    /// <summary>
    /// Логика взаимодействия для ClientOrderWindow.xaml
    /// </summary>
    public partial class ClientOrderWindow : Window
    {

   


        private List<Order> _orders = new List<Order>();
        public ClientOrderWindow()
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
            ClientAddEditOrderWindow clientAddEditOrderWindow = new ClientAddEditOrderWindow(existingOrder);
            clientAddEditOrderWindow.Show();
            this.Close();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            ClientAddEditOrderWindow clientAddEditOrderWindow = new ClientAddEditOrderWindow(null);
            clientAddEditOrderWindow.Show();
            this.Close();
        }
    }
}
