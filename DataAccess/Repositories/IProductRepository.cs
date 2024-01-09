using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IProductRepository
    {
        void InsertProduct(ProductObject product);
        IEnumerable<ProductObject> GetProducts();
        void UpdateProduct(ProductObject product);
        void DeleteProduct(ProductObject product);
    }
}
