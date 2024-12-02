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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace demEx
{
    /// <summary>
    /// Логика взаимодействия для ClientAddEditOrderWindow.xaml
    /// </summary>
    public partial class ClientAddEditOrderWindow : Window
    {

        /*private Order _order = new Order();
        private List<Order> _orders = new List<Order>();
*/

        public ClientAddEditOrderWindow(Order existingOrder)
        {
            InitializeComponent();
           /* _order = existingOrder;

            _orders = new Base().ReadObjectFromFile();

            modelCB.ItemsSource = new Base().models;
            typeCB.ItemsSource = new Base().types;

            modelCB.SelectedIndex = 0;
            typeCB.SelectedIndex = 0;
            
            if(_order != null)
            {
                modelCB.SelectedIndex = Array.IndexOf(new Base().models, _order.Model);
                typeCB.SelectedIndex = Array.IndexOf(new Base().models, _order.Model);
                deffectTB.Text = _order.Deffect;
                descriptionTB.Text = _order.Comment;
            }*/
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {

           /* if (_order != null)
                EditOrder();
            else
                AddNewOrder();

            new Base().WriteObjectToFile(_orders);
            ClientOrderWindow clientOrderWindow = new ClientOrderWindow();
            clientOrderWindow.Show();
            Close();*/
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            ClientOrderWindow clientOrderWindow = new ClientOrderWindow();
            clientOrderWindow.Show();
            this.Close();
        }

        private void AddNewOrder()
        {
          /*  Order newOrder = new Order
            {
                Id = _orders.Max(i => i.Id) + 1,
                Model = modelCB.SelectedItem.ToString(),
                Type = typeCB.SelectedItem.ToString(),
                Deffect = deffectTB.Text,
                ClientName = "SANYA",
                Comment = descriptionTB.Text,
                Status = new Base().statuses[0]
            };
            _orders.Add(newOrder);*/
        }

        private void EditOrder()
        {
           /* var index = _orders.FindIndex(i => i.Id == _order.Id);

            _order.Model = modelCB.SelectedItem.ToString();
            _order.Type = typeCB.SelectedItem.ToString();
            _order.Deffect = deffectTB.Text;
            _order.ClientName = "SANYA";
            _order.Comment = descriptionTB.Text;
            _order.Status = new Base().statuses[0];

            
            _orders[index] = _order;*/
        }
    }
}
