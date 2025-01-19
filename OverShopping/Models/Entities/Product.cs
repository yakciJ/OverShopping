namespace OverShopping.Models.Entities
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public decimal productPrice { get; set; }
        public int category_id { get; set; }
    }
}
