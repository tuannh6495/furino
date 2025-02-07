namespace Furino.WebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public bool IsNew { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Price { get; set; }
        public double PercentDiscount
        {
            get
            {
                return (double)(OldPrice - Price) * 100 / (double)OldPrice;
            }
        }
        public string? ImageUrl
        {
            get
            {
                return $"/img/products/{Id}.png";
            }
        }
    }
}