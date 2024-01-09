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
    /// Interaction logic for InsertProductPopup.xaml
    /// </summary>
    public partial class InsertProductPopup : UserControl
    {
        IProductRepository _productRepository;
        public InsertProductPopup(IProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
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

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            ProductObject product = new ProductObject
            {
                CategoryId = Int32.Parse(txtCategory.Text),
                ProductName = txtProductName.Text,
                Weight = txtWeight.Text,
                UnitPrice = Decimal.Parse(txtUnitPrice.Text.Replace('$', ' ').Trim()),
                UnitsInStock = Int32.Parse(txtUnitInStock.Text)
            };
            _productRepository.InsertProduct(product);

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
