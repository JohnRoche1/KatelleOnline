using System;
using System.Collections.Generic;

namespace KatelleOnline.Models
{
    public interface IBasket    
    {
        Guid BasketId { get; set; }
        int BasketCount { get; set; }
        decimal BasketTotalPrice { get; set; }
        List<BasketItem> BasketItems { get; set; }
    }


    public interface IBasketItem
    {
        Product Product { get; set; }
        int ProductCount { get; set; }
    }
}