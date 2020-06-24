using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using KatelleOnline.Data;
using KatelleOnline.Helper;
using KatelleOnline.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KatelleOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductRepository _repository;
        private IBasket basket;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }


        // GET api/product/categoryId/description
        [HttpGet]
        [HttpGet("{categoryId}/{description}")]
        public ActionResult GetProducts(int? categoryId, string description)
        {
            IEnumerable<IProduct> products = _repository.GetAllProducts(categoryId, description);
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products.ToList());
        }


        public ActionResult AddItemToBasket(int id)
        {
            IProduct product = _repository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                basket = AddToBasket(product);
            }
            
            return Ok(basket);
        }

        private IBasket AddToBasket2(IProduct product)
        {
            HttpContext.Session.SetObjectAsJson("Basket", basket);

            return basket;
        }

        private IBasket AddToBasket(IProduct product)
        {
            var basket = HttpContext.Session.GetObjectFromJson<Basket>("Basket");

            if (basket == null)
            {
                basket = new Basket();
            }

            var basketItem = basket.BasketItems.Where(x => x.Product == product).FirstOrDefault();
            if(basketItem == null)
            {
                basket.BasketItems.Add(new BasketItem()
                {
                    Product = (Product)product,
                    ProductCount = 1
                });
            }
            else
            {
                basketItem.ProductCount++;                
            }
            basket.BasketCount++;
            basket.BasketTotalPrice += product.UnitPrice;

            HttpContext.Session.SetObjectAsJson("Basket", basket);

            return basket;
        }
    }
}