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
    /// Interaction logic for InsertMemberPopup.xaml
    /// </summary>
    public partial class InsertMemberPopup : UserControl
    {
        IMemberRepository _memberRepository;
        public InsertMemberPopup(IMemberRepository memberRepository)
        {
            InitializeComponent();
            _memberRepository = memberRepository;
        }
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            MemberObject member = new MemberObject
            {
                Email = txtEmail.Text,
                CompanyName = txtCompanyName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Password
            };
            _memberRepository.InsertMember(member);
            
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
