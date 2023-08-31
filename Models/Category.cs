namespace Store.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }

        public List<Product> Products { get; set; }
    }
}
