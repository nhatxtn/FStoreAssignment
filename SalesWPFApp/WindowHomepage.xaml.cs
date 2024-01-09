using BusinessObject;
using DataAccess.Repositories;
using SalesWPFApp.UserControlComponent;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Provider;
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
    /// Interaction logic for WindowHomepage.xaml
    /// </summary>
    public partial class WindowHomepage : Page
    {
        string currentPage { get; set; }
        IMemberRepository _memberRepository;
        IProductRepository _productRepository;
        IOrderRepository _orderRepository;
        object currentObj { get; set; }
        public WindowHomepage(IMemberRepository memberRepository, IProductRepository productRepository, IOrderRepository orderRepository)
        {
            InitializeComponent();
            _memberRepository = memberRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;           
        }

        public void LoadMembers(object sender, RoutedEventArgs e)
        {
            ObservableCollection<GridViewColumn> memberColumns = new ObservableCollection<GridViewColumn>();
            memberColumns.Add(new GridViewColumn
            {
                Header = "Member ID",
                DisplayMemberBinding = new System.Windows.Data.Binding("MemberId")
            });
            memberColumns.Add(new GridViewColumn
            {
                Header = "Email",
                DisplayMemberBinding = new System.Windows.Data.Binding("Email")
            });
            memberColumns.Add(new GridViewColumn
            {
                Header = "Company Name",
                DisplayMemberBinding = new System.Windows.Data.Binding("CompanyName")
            });
            memberColumns.Add(new GridViewColumn
            {
                Header = "City",
                DisplayMemberBinding = new System.Windows.Data.Binding("City")
            });
            memberColumns.Add(new GridViewColumn
            {
                Header = "Country",
                DisplayMemberBinding = new System.Windows.Data.Binding("Country")
            });
            memberColumns.Add(new GridViewColumn
            {
                Header = "Password",
                DisplayMemberBinding = new System.Windows.Data.Binding("Password")
            });

            if (objectList.View is GridView gridView)
            {
                gridView.Columns.Clear();

                // Add the new columns to the GridView
                foreach (var column in memberColumns)
                {
                    gridView.Columns.Add(column);
                }
            }
            labelTitle.Content = "Member Management";
            currentPage = "Member";
            objectList.ItemsSource = _memberRepository.GetMembers();
        }
        public void LoadProducts(object sender, RoutedEventArgs e)
        {
            ObservableCollection<GridViewColumn> productColumns = new ObservableCollection<GridViewColumn>();
            productColumns.Add(new GridViewColumn
            {
                Header = "Product ID",
                DisplayMemberBinding = new System.Windows.Data.Binding("ProductId")
            });
            productColumns.Add(new GridViewColumn
            {
                Header = "Category ID",
                DisplayMemberBinding = new System.Windows.Data.Binding("CategoryId")
            });
            productColumns.Add(new GridViewColumn
            {
                Header = "Product Name",
                DisplayMemberBinding = new System.Windows.Data.Binding("ProductName")
            });
            productColumns.Add(new GridViewColumn
            {
                Header = "Weight",
                DisplayMemberBinding = new System.Windows.Data.Binding("Weight")
            });
            productColumns.Add(new GridViewColumn
            {
                Header = "Unit Price",
                DisplayMemberBinding = new System.Windows.Data.Binding("UnitPrice")
            });
            productColumns.Add(new GridViewColumn
            {
                Header = "Unit in Stock",
                DisplayMemberBinding = new System.Windows.Data.Binding("UnitsInStock")
            });

            if (objectList.View is GridView gridView)
            {
                gridView.Columns.Clear();

                // Add the new columns to the GridView
                foreach (var column in productColumns)
                {
                    gridView.Columns.Add(column);
                }
            }
            labelTitle.Content = "Product Management";
            currentPage = "Product";
            objectList.ItemsSource = _productRepository.GetProducts();
        }
        public void LoadOrders(object sender, RoutedEventArgs e)
        {
            ObservableCollection<GridViewColumn> orderColumns = new ObservableCollection<GridViewColumn>();
            orderColumns.Add(new GridViewColumn
            {
                Header = "Order ID",
                DisplayMemberBinding = new System.Windows.Data.Binding("OrderId")
            });
            orderColumns.Add(new GridViewColumn
            {
                Header = "Member ID",
                DisplayMemberBinding = new System.Windows.Data.Binding("MemberId")
            });
            orderColumns.Add(new GridViewColumn
            {
                Header = "Order Date",
                DisplayMemberBinding = new System.Windows.Data.Binding("OrderDate")
            });
            orderColumns.Add(new GridViewColumn
            {
                Header = "Required Date",
                DisplayMemberBinding = new System.Windows.Data.Binding("RequiredDate")
            });
            orderColumns.Add(new GridViewColumn
            {
                Header = "Shipped Date",
                DisplayMemberBinding = new System.Windows.Data.Binding("ShippedDate")
            });
            orderColumns.Add(new GridViewColumn
            {
                Header = "Freight",
                DisplayMemberBinding = new System.Windows.Data.Binding("Freight")
            });

            if (objectList.View is GridView gridView)
            {
                gridView.Columns.Clear();

                // Add the new columns to the GridView
                foreach (var column in orderColumns)
                {
                    gridView.Columns.Add(column);
                }
            }
            labelTitle.Content = "Order Management";
            currentPage = "Order";
            objectList.ItemsSource = _orderRepository.GetOrders();
        }
        private void GetCurrentSelection(object sender, SelectionChangedEventArgs e)
        {
            if (objectList.SelectedItem != null)
            {
                if (currentPage.Equals("Member")) currentObj = (MemberObject)objectList.SelectedItem;
                else if (currentPage.Equals("Product")) currentObj = (ProductObject)objectList.SelectedItem;
                else if (currentPage.Equals("Order")) currentObj = (OrderObject)objectList.SelectedItem;
            }
        }
        private void btnMemberNav_Click(object sender, RoutedEventArgs e)
        {
            lblSearchProduct.Visibility = Visibility.Hidden;
            txtSearchProduct.Visibility = Visibility.Hidden;
            btnSearchProduct.Visibility = Visibility.Hidden;

            lblReportTitle.Visibility = Visibility.Hidden;
            lblFrom.Visibility = Visibility.Hidden;
            dtStartDate.Visibility = Visibility.Hidden;
            lblTo.Visibility = Visibility.Hidden;
            dtEndDate.Visibility = Visibility.Hidden;
            btnExport.Visibility = Visibility.Hidden;
            LoadMembers(sender, e);
        }
        private void btnProductNav_Click(object sender, RoutedEventArgs e)
        {
            lblSearchProduct.Visibility = Visibility.Visible;
            txtSearchProduct.Visibility = Visibility.Visible;
            btnSearchProduct.Visibility = Visibility.Visible;

            lblReportTitle.Visibility = Visibility.Hidden;
            lblFrom.Visibility = Visibility.Hidden;
            dtStartDate.Visibility = Visibility.Hidden;
            lblTo.Visibility = Visibility.Hidden;
            dtEndDate.Visibility = Visibility.Hidden;
            btnExport.Visibility = Visibility.Hidden;

            LoadProducts(sender, e);
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchText = txtSearchProduct.Text.ToLower();
            var productList = _productRepository.GetProducts()
                .Where(product => product.ProductName.ToLower().Contains(searchText) || 
                product.UnitPrice.ToString().ToLower().Contains(searchText) || 
                product.ProductId.ToString().ToLower().Contains(searchText) ||
                product.UnitsInStock.ToString().ToLower().Contains(searchText));
            objectList.ItemsSource = productList;
        }
        private void btnOrderNav_Click(object sender, RoutedEventArgs e)
        {
            lblSearchProduct.Visibility = Visibility.Hidden;
            txtSearchProduct.Visibility = Visibility.Hidden;
            btnSearchProduct.Visibility = Visibility.Hidden;

            lblReportTitle.Visibility = Visibility.Visible;
            lblFrom.Visibility = Visibility.Visible;
            dtStartDate.Visibility = Visibility.Visible;
            lblTo.Visibility = Visibility.Visible;
            dtEndDate.Visibility = Visibility.Visible;
            btnExport.Visibility = Visibility.Visible;

            LoadOrders(sender, e);
        }
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new WindowLogin(_memberRepository, _productRepository, _orderRepository));
        }
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        { 
            if (currentPage.Equals("Member"))
            {
                InsertMemberPopup insertMemberPopup = new InsertMemberPopup(_memberRepository);
                Window popupWindow = new Window
                {
                    Content = insertMemberPopup,
                    Title = "Insert Member",
                    SizeToContent = SizeToContent.WidthAndHeight,
                    ResizeMode = ResizeMode.NoResize,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Owner = Window.GetWindow(this)
                };
                popupWindow.ShowDialog();               
            } 
            else if (currentPage.Equals("Product"))
            {
                InsertProductPopup insertProductPopup = new InsertProductPopup(_productRepository);
                Window popupWindow = new Window
                {
                    Content = insertProductPopup,
                    Title = "Insert Product",
                    SizeToContent = SizeToContent.WidthAndHeight,
                    ResizeMode = ResizeMode.NoResize,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Owner = Window.GetWindow(this)
                };
                popupWindow.ShowDialog();
            } 
            else if (currentPage.Equals("Order"))
            {
                InsertOrderPopup insertOrderPopup = new InsertOrderPopup(_orderRepository);
                Window popupWindow = new Window
                {
                    Content = insertOrderPopup,
                    Title = "Insert Product",
                    SizeToContent = SizeToContent.WidthAndHeight,
                    ResizeMode = ResizeMode.NoResize,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Owner = Window.GetWindow(this)
                };
                popupWindow.ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (currentObj != null)
            {
                if (currentPage.Equals("Member"))
                {
                    _memberRepository.DeleteMember((MemberObject)currentObj);
                    LoadMembers(sender, e);
                }
                else if (currentPage.Equals("Product"))
                {
                    _productRepository.DeleteProduct((ProductObject)currentObj);
                    LoadProducts(sender, e);
                }
                else if (currentPage.Equals("Order")) 
                {
                    _orderRepository.DeleteOrder((OrderObject)currentObj);
                    LoadOrders(sender, e);
                }
                
            }
        }
        private void UpdateObject(object sender, RoutedEventArgs e)
        {
            if(currentPage != null && currentObj != null)
            {
                if (currentPage.Equals("Member"))
                {
                    UpdateMemberPopup updateMember = new UpdateMemberPopup((MemberObject)currentObj);
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
                else if (currentPage.Equals("Product"))
                {
                    UpdateProductPopup updateProduct = new UpdateProductPopup((ProductObject)currentObj);
                    Window popupWindow = new Window
                    {
                        Content = updateProduct,
                        Title = "Update Product",
                        SizeToContent = SizeToContent.WidthAndHeight,
                        ResizeMode = ResizeMode.NoResize,
                        WindowStartupLocation = WindowStartupLocation.CenterOwner,
                        Owner = Window.GetWindow(this)
                    };
                    popupWindow.ShowDialog();
                }
                else if (currentPage.Equals("Order"))
                {
                    UpdateOrderPopup updateOrder = new UpdateOrderPopup((OrderObject)currentObj);
                    Window popupWindow = new Window
                    {
                        Content = updateOrder,
                        Title = "Update Order",
                        SizeToContent = SizeToContent.WidthAndHeight,
                        ResizeMode = ResizeMode.NoResize,
                        WindowStartupLocation = WindowStartupLocation.CenterOwner,
                        Owner = Window.GetWindow(this)
                    };
                    popupWindow.ShowDialog();
                }
            }
            
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(dtStartDate.ToString());
            DateTime endDate = DateTime.Parse(dtEndDate.ToString());
            var order = _orderRepository.GetOrders()
                .Where(ord => ord.ShippedDate > startDate && ord.ShippedDate < endDate)
                .OrderByDescending(ord => ord.ShippedDate);
            objectList.ItemsSource = order;
        }

    }
}
