using BusinessObject;
using DataAccess.Repositories;
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

namespace SalesWPFApp.UserControlComponent
{
    /// <summary>
    /// Interaction logic for UpdateOrderPopup.xaml
    /// </summary>
    public partial class UpdateOrderPopup : UserControl
    {
        IOrderRepository _orderRepository = new OrderRepository();
        OrderObject orderObject { get; set; }
        public UpdateOrderPopup(OrderObject order)
        {
            InitializeComponent();
            orderObject = order;
            txtOrderId.Text = orderObject.OrderId.ToString();
            txtMemId.Text = orderObject.MemberId.ToString();
            dtOrderDate.Text = orderObject.OrderDate.ToString();
            dtRequiredDate.Text = orderObject.RequiredDate.ToString();
            dtShippedDate.Text = orderObject.ShippedDate.ToString();
            txtFreight.Text = orderObject.Freight.ToString();
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            OrderObject order = new OrderObject
            {
                OrderId = Int32.Parse(txtOrderId.Text),
                MemberId = Int32.Parse(txtMemId.Text),
                OrderDate = DateTime.Parse(dtOrderDate.Text),
                RequiredDate = DateTime.Parse(dtRequiredDate.Text),
                ShippedDate = DateTime.Parse(dtShippedDate.Text),
                Freight = Decimal.Parse(txtFreight.Text)
            };
            _orderRepository.UpdateOrder(order);
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }
    }
}
