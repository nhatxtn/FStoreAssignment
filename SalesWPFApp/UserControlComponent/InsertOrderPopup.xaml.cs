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
    /// Interaction logic for InsertOrderPopup.xaml
    /// </summary>
    public partial class InsertOrderPopup : UserControl
    {
        IOrderRepository _orderRepository;
        public InsertOrderPopup(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
            InitializeComponent();
        }
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            OrderObject order = new OrderObject
            {
                MemberId = Int32.Parse(txtMemId.Text),
                OrderDate = DateTime.Parse(dtOrderDate.Text),
                RequiredDate = DateTime.Parse(dtRequiredDate.Text),
                ShippedDate = DateTime.Parse(dtShippedDate.Text),
                Freight = Decimal.Parse(txtFreight.Text)
            };
            _orderRepository.InsertOrder(order);

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
