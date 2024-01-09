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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IMemberRepository _memberRepository;
        IOrderDetailRepository _orderDetailRepository;
        IOrderRepository _orderRepository;
        IProductRepository  _productRepository;

        public MainWindow(IMemberRepository memberRepository, 
            IOrderDetailRepository orderDetailRepository, 
            IOrderRepository orderRepository, 
            IProductRepository productRepository)
        {
            InitializeComponent();
            _memberRepository = memberRepository;
            _orderDetailRepository = orderDetailRepository;
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            frMain.Content = new WindowLogin(_memberRepository, _productRepository, _orderRepository);
            this.SizeToContent = SizeToContent.WidthAndHeight;
            
        }
    }
}
