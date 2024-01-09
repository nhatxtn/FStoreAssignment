using BusinessObject;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for UpdateProductPopup.xaml
    /// </summary>
    public partial class UpdateProductPopup : UserControl
    {
        IProductRepository _productRepository = new ProductRepository();
        ProductObject pro { get; set; }
        public UpdateProductPopup(ProductObject product)
        {
            InitializeComponent();
            pro = product;
            txtProId.Text = pro.ProductId.ToString();
            txtCategory.Text = pro.CategoryId.ToString();
            txtProductName.Text = pro.ProductName.ToString();
            txtWeight.Text = pro.Weight.ToString();
            txtUnitPrice.Value = Double.Parse(pro.UnitPrice.ToString());
            txtUnitInStock.Value = Int32.Parse(pro.UnitsInStock.ToString());
        }
        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void FloatTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Use a regular expression to allow only numeric input with a decimal point
            if (Regex.IsMatch(e.Text, "[0-9.]") || ContainsMoreThanOneDecimalPoint(e.Text, txtUnitPrice.Text))
            {
                e.Handled = true; // Ignore the input
            }
        }
        private bool ContainsMoreThanOneDecimalPoint(string input, string currentText)
        {
            // Check if the input contains more than one decimal point
            if (input == "." && currentText.Contains("."))
            {
                return true;
            }

            return false;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ProductObject product = new ProductObject
            {
                ProductId = Int32.Parse(txtProId.Text),
                CategoryId = Int32.Parse(txtCategory.Text),
                ProductName = txtProductName.Text,
                Weight = txtWeight.Text,
                UnitPrice = Decimal.Parse(txtUnitPrice.Text.Replace('$', ' ').Trim()),
                UnitsInStock = Int32.Parse(txtUnitInStock.Text)
            };
            _productRepository.UpdateProduct(product);
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
