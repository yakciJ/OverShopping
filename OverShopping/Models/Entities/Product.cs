namespace OverShopping.Models.Entities
{
    public class Product
    {
        public int productId { get; set; }
        public required string productName { get; set; }
        public string? productDescription { get; set; }
        public string? productImage { get; set; }
        public decimal productPrice { get; set; }
        public int productStock { get; set; }
        public int productSold { get; set; }
        public int totalReview { get; set; }
        public decimal productRating { get; set; }
        public int category_id { get; set; }
        public DateTime created_at { get; set; }

        public ICollection<Review>? reviews { get; set; }
        public ICollection<Cart>? carts { get; set; }
        public ICollection<Order>? orders { get; set; }
        public ICollection<Transaction>? transactions { get; set; }
        public ICollection<SearchHistory>? searchHistory { get; set; }
        public ICollection<ActivityHistory>? activityHistory { get; set; }

    }
}
