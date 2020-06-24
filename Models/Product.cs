using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace KatelleOnline.Models
{
    // This is a cut down version of a Product (Would name this class something like ProductBasketItem)
    public class Product : IProduct
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "categoryId")]
        public int CategoryId { get; set; }

        [JsonIgnore]
        public string ProductCode { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "unitPrice")]
        public decimal UnitPrice { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageURL { get; set; }

    }
}
