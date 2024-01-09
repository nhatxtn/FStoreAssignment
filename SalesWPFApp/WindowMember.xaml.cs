using BusinessObject;
using DataAccess.Repositories;
using SalesWPFApp.UserControlComponent;
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
    /// Interaction logic for WindowMember.xaml
    /// </summary>
    public partial class WindowMember : Page
    {
        IMemberRepository _memberRepository = new MemberRepository();
        IOrderRepository _orderRepository = new OrderRepository();
        IProductRepository _productRepository = new ProductRepository();
        MemberObject memberObject { get; set; }
        public WindowMember(MemberObject member)
        {
            InitializeComponent();
            memberObject = member;
            LoadContent();
            lvMember.Visibility = Visibility.Hidden;
        }
        private void LoadContent()
        {
            memberObject = _memberRepository.GetMembers().FirstOrDefault(mem => memberObject.MemberId == mem.MemberId);
            lblMemberId.Content = memberObject.MemberId;
            lblEmail.Content = memberObject.Email;
            lblCompanyName.Content = memberObject.CompanyName;
            lblCity.Content = memberObject.City;
            lblCountry.Content = memberObject.Country;
            lblWelcome.Content = "Welcome back, " + memberObject.Email;
        }
        private void btnOrderView_Click(object sender, RoutedEventArgs e)
        {
            lvMember.Visibility = Visibility.Visible;
            labelTitle.Content = "Your Order";
            lvMember.ItemsSource = _orderRepository.GetOrders()
                .Where(ord => ord.MemberId.Equals(memberObject.MemberId));
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new WindowLogin(_memberRepository, _productRepository, _orderRepository));
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            labelTitle.Content = "Your Profile";
            LoadContent();
            lvMember.Visibility = Visibility.Hidden;        
        }

        private void btnEditProfile_Click(object sender, RoutedEventArgs e)
        {
            UpdateMemberPopup updateMember = new UpdateMemberPopup(memberObject);
            Window popupWindow = new Window
            {
                Content = updateMember,
                Title = "Update Member",
                SizeToContent = SizeToContent.WidthAndHeight,
                ResizeMode = ResizeMode.NoResize,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = Window.GetWindow(this)
            };
            popupWindow.ShowDialog();
        }
    }
}
