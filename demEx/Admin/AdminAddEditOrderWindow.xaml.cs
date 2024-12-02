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
    /// Логика взаимодействия для AdminAddEditOrderWindow.xaml
    /// </summary>
    public partial class AdminAddEditOrderWindow : Window
    {

        private Order _order = new Order();
        private List<Order> _orders = new List<Order>();

        public AdminAddEditOrderWindow(Order existingsOrder)
        {
            InitializeComponent();

            _order = existingsOrder;
            _orders = new Base().ReadObjectFromFile();

            statusCB.ItemsSource = new Base().statuses;
            prorityCB.ItemsSource = new Base().priorities;

            statusCB.SelectedIndex = 0;
            prorityCB.SelectedIndex = 0;

            if (_order != null)
            {
                statusCB.SelectedIndex = Array.IndexOf(new Base().statuses, _order.Model);
                prorityCB.SelectedIndex = Array.IndexOf(new Base().priorities, _order.Model);
                empNameTB.Text = _order.EmployeeName;
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (_order != null)
                EditOrder();
            else
                AddNewOrder();

            new Base().WriteObjectToFile(_orders);
            AdminOrderWindow adminOrderWindow = new AdminOrderWindow();
            adminOrderWindow.Show();
            this.Close();
        }

        private void AddNewOrder()
        {
            Order newOrder = new Order()
            {
                Id = _orders.Max(x => x.Id) + 1,
                Status = statusCB.SelectedItem.ToString(),
                Priority = prorityCB.SelectedItem.ToString(),
                EmployeeName = empNameTB.Text,
            };

        }

        private void EditOrder()
        {
            var index = _orders.FindIndex(i => i.Id == _order.Id);

            _order.Status = statusCB.SelectedItem.ToString();
            _order.Priority = prorityCB.SelectedItem.ToString();
            _order.EmployeeName = empNameTB.Text;

            _orders[index] = _order;
        }

     
    }
}
