using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(ProductObject product)
                => DAOFactory.GetInstance<ProductDAO>().DeleteProduct(product);

        public IEnumerable<ProductObject> GetProducts()
                => DAOFactory.GetInstance<ProductDAO>().GetProducts();

        public void InsertProduct(ProductObject product)
                => DAOFactory.GetInstance<ProductDAO>().InsertProduct(product);

        public void UpdateProduct(ProductObject product)
                => DAOFactory.GetInstance<ProductDAO>().UpdateProduct(product);
    }
}
