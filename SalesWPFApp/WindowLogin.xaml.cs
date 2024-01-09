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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Page
    {
        IMemberRepository _memberRepository;
        IProductRepository _productRepository;
        IOrderRepository _orderRepository;
        public WindowLogin(IMemberRepository memberRepository, IProductRepository productRepository, IOrderRepository orderRepository)
        {
            InitializeComponent();
            _memberRepository = memberRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            if (username.Equals("admin@fstore.com") && password.Equals("admin@@"))
            {
                Console.WriteLine("Logged in!");
                NavigationService?.Navigate(new WindowHomepage(_memberRepository, _productRepository, _orderRepository));
            } else if (_memberRepository.CheckCredentials(username, password))
            {
                MemberObject member = _memberRepository.GetMembers()
                    .FirstOrDefault(mem => mem.Email.Equals(username) && mem.Password.Equals(password));
                NavigationService?.Navigate(new WindowMember(member));
            }
            else
            {
                lblLoginErr.Visibility = Visibility.Visible;
            }
        }
    }
}
