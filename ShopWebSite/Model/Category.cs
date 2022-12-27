namespace ShopWebSite.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Img { get; set; }
        public int Count { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
