using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatelleOnline.Models
{
    public class Basket : IBasket
    {
        public Basket()
        {
            BasketItems = new List<BasketItem>();
            BasketId = Guid.NewGuid();
        }
        // Used if temp storing basket
        public Guid BasketId { get; set; }

        public List<BasketItem> BasketItems { get; set; }

        public int BasketCount { get; set; }

        public decimal BasketTotalPrice { get; set; }
    }

    public class BasketItem
    {
        public Product Product { get; set; }
        public int ProductCount { get; set; }
    }
}
