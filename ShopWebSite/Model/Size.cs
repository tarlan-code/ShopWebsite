namespace ShopWebSite.Model
{
    public class Size
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
