namespace KatelleOnline.Models
{
    public interface IProduct
    {
        int CategoryId { get; set; }
        string Description { get; set; }
        int Id { get; set; }
        string ImageURL { get; set; }
        string ProductCode { get; set; }
        decimal UnitPrice { get; set; }
    }
}