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
    /// Interaction logic for UpdateMemberPopup.xaml
    /// </summary>
    public partial class UpdateMemberPopup : UserControl
    {
        IMemberRepository _memberRepository = new MemberRepository();
        MemberObject member { get; set; }

        public UpdateMemberPopup(MemberObject obj)
        {
            InitializeComponent();
            member = obj;
            txtId.Text = member.MemberId.ToString();
            txtEmail.Text = member.Email.ToString();
            txtCompanyName.Text = member.CompanyName.ToString();
            txtCity.Text = member.City.ToString();
            txtCountry.Text = member.Country.ToString();
            txtPassword.Password = member.Password.ToString();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            MemberObject member = new MemberObject
            {
                MemberId = Int32.Parse(txtId.Text),
                Email = txtEmail.Text,
                CompanyName = txtCompanyName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Password
            };
            _memberRepository.UpdateMember(member);
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
