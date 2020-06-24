using KatelleOnline.Models;
using System.Collections.Generic;

namespace KatelleOnline.Data
{
    public interface IProductRepository
    {
     
        IEnumerable<IProduct> GetAllProducts(int? catetogyId, string productDescription);
        IProduct GetProductById(int Id);
    }
}
