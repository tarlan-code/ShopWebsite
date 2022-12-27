﻿namespace ShopWebSite.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public decimal Price { get; set; }

        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Size> Sizes { get; set; }
        public List<Color> Colors { get; set; }
        public List<Image> Images { get; set; }

        public Product()
        {
            Images = new List<Image>();
            Sizes = new List<Size>();
            Colors = new List<Color>();
        }
    }
}
