using Microsoft.AspNetCore.Mvc;
using ShopWebSite.Model;
using System.Collections.Generic;

namespace ShopWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product>? products = new List<Product>()
            {
                new Product(){Id=1,Name="Nikon D3500",Price=400.00m,Images={ (new Image() {Id=1,Name= "product-1.jpg" }) } },
                new Product(){Id=2,Name="Puma sweater",Price=20.00m,Images={ (new Image() {Id=2,Name= "product-2.jpg" }) }},
                new Product(){Id=3,Name="Table Lamp",Price=40.00m,Images={ (new Image() {Id=3,Name= "product-3.jpg" }) }},
                new Product(){Id=4,Name="Nike shoe",Price=123.00m,Images={ (new Image() {Id=4,Name= "product-4.jpg" }) }},
                new Product(){Id=5,Name="DJI Drone",Price=500.00m,Images={ (new Image() {Id=5,Name= "product-5.jpg" }) }},
                new Product(){Id=6,Name="Apple Watch",Price=399.00m,Images={ (new Image() {Id=6,Name= "product-6.jpg" }) }},
                new Product(){Id=7,Name="T-shirt",Price=25.00m,Images={ (new Image() {Id=7,Name= "product-7.jpg" }) }},
                new Product(){Id=8,Name="Face cream",Price=10.00m,Images={ (new Image() {Id=8,Name= "product-8.jpg" } )}}
            };

            List<Carousel> carousels = new List<Carousel>()
            {
                new Carousel(){Id=1,Title="Men Fashion",Img="carousel-1.jpg",Description="Lorem rebum magna amet lorem magna erat diam stet. Sadips duo stet amet amet ndiam elitr ipsum diam"},
                new Carousel(){Id=2,Title="Women Fashion",Img="carousel-2.jpg",Description="Lorem rebum magna amet lorem magna erat diam stet. Sadips duo stet amet amet ndiam elitr ipsum diam"},
                new Carousel(){Id=3,Title="Kids Fashion",Img="carousel-3.jpg",Description="Lorem rebum magna amet lorem magna erat diam stet. Sadips duo stet amet amet ndiam elitr ipsum diam"},
            };


            List<Category> categories = new List<Category>()
            {
                new Category(){Id=1,Name="Clothing",Img="cat-1.jpg",Count=100},
                new Category(){Id=1,Name="Technology",Img="cat-2.jpg",Count=100},
                new Category(){Id=1,Name="Shoes",Img="cat-3.jpg",Count=100},
                new Category(){Id=1,Name="Cosmetic",Img="cat-4.jpg",Count=100},
                new Category(){Id=1,Name="Shoes",Img="cat-3.jpg",Count=100},
                new Category(){Id=1,Name="Technology",Img="cat-2.jpg",Count=100},
                new Category(){Id=1,Name="Cosmetic",Img="cat-4.jpg",Count=100},
                new Category(){Id=1,Name="Clothing",Img="cat-1.jpg",Count=100},
                new Category(){Id=1,Name="Cosmetic",Img="cat-4.jpg",Count=100},
                new Category(){Id=1,Name="Shoes",Img="cat-3.jpg",Count=100},
                new Category(){Id=1,Name="Clothing",Img="cat-1.jpg",Count=100},
                new Category(){Id=1,Name="Technology",Img="cat-2.jpg",Count=100},

            };
            ViewData["Categories"] = categories;
            ViewBag.carousels = carousels;
            return View(products);
        }

        public IActionResult Detail()
        {
            Product product = new Product()
            {
                Id = 1,
                Name = "Nikon D3500",
                Images = { new Image { Id=1,Name = "product-1.jpg" }, new Image { Id = 9, Name = "product-1-2.jpg" }, new Image { Id = 10, Name = "product-1-3.jpg" }, new Image { Id = 11, Name = "product-1-4.jpg" } },
                Price = 400.00m,
                Description = "Volup erat ipsum diam elitr rebum et dolor. Est nonumy elitr erat diam stet sit clita ea. Sanc ipsum et, labore clita lorem magna duo dolor no sea Nonumy",
                Sizes = {new Size { Id=1,Type="XS"}, new Size { Id = 2, Type = "S" }, new Size { Id = 3, Type = "M" }, new Size { Id = 4, Type = "L" }, new Size { Id = 5, Type = "XL" } },
                Colors = {new Color { Id=1, Name = "Black"}, new Color { Id = 2, Name = "White" }, new Color { Id = 3, Name = "Red" }, new Color { Id = 4, Name = "Blue" }, new Color { Id = 5, Name = "Green" } }

            };
            return View(product);
        }

        public IActionResult Shop()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Id=1,Name="Nikon D3500",Price=400.00m,Images={ (new Image() {Id=1,Name= "product-1.jpg" }) } },
                new Product(){Id=2,Name="Puma sweater",Price=20.00m,Images={ (new Image() {Id=2,Name= "product-2.jpg" }) }},
                new Product(){Id=3,Name="Table Lamp",Price=40.00m,Images={ (new Image() {Id=3,Name= "product-3.jpg" }) }},
                new Product(){Id=4,Name="Nike shoe",Price=123.00m,Images={ (new Image() {Id=4,Name= "product-4.jpg" }) }},
                new Product(){Id=5,Name="DJI Drone",Price=500.00m,Images={ (new Image() {Id=5,Name= "product-5.jpg" }) }},
                new Product(){Id=6,Name="Apple Watch",Price=399.00m,Images={ (new Image() {Id=6,Name= "product-6.jpg" }) }},
                new Product(){Id=7,Name="T-shirt",Price=25.00m,Images={ (new Image() {Id=7,Name= "product-7.jpg" }) }},
                new Product(){Id=8,Name="Face cream",Price=10.00m,Images={ (new Image() {Id=8,Name= "product-8.jpg" } )}},
                new Product(){Id=8,Name="Chair",Price=120.00m,Images={ (new Image() {Id=9,Name= "product-8.jpg" }) }}

            };


            return View(products);
        }
    }
}
