namespace AmazonApp.Areas.Inventory.Models
{
    public class AddProductModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal? Price { get; set; }

        public string? Category { get; set; }
    }
}
