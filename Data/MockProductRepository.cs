using KatelleOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatelleOnline.Data
{
    public class MockProductRepository : IProductRepository
    {
        // Create a List of objects  
        List<IProduct> _products =  new List<IProduct>
{
            new Product { Id = 1, ProductCode="A1", Description="Product A1", UnitPrice=1.11m, ImageURL="\\image\\1" },
            new Product { Id = 2, ProductCode="A2", Description="Product A2", UnitPrice=2.22m, ImageURL="\\image\\2" },
            new Product { Id = 3, ProductCode="A3", Description="Product A3", UnitPrice=3.33m, ImageURL="\\image\\3" },
            new Product { Id = 4, ProductCode="A4", Description="Product A4", UnitPrice=4.44m, ImageURL="\\image\\4" },
            new Product { Id = 5, ProductCode="A5", Description="Product A5", UnitPrice=5.55m, ImageURL="\\image\\5" },
        };

        public IEnumerable<IProduct> GetAllProducts(int? catetogyId, string productDescription)
        {
            return _products;
        }

        public IProduct GetProductById(int id)
        {
            var product = _products.Where(x => x.Id == id).FirstOrDefault();
            if (product != null)
            {
                return product;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
