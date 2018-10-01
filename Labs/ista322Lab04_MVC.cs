/*-----------------Homecontroller.cs--------------------------------------------------------*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;




namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            //Product[] productArray =
                var products = new[]
            {
                new {Name = "Kayak", Price = 275M } ,
                new {Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
            };


            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"
            ));
            //return View(products.Select(p => p.GetType().Name));
            /* decimal cartTotal = cart.TotalPrices();
             decimal arrayTotal = productArray.TotalPrices();
             decimal priceTotal = productArray.FilterByPrice(20).TotalPrices();

             return View("Index", new string[] {$"Cart Total: {cartTotal:C2}",
                     $"Array Total: {arrayTotal:C2}"});




             //return View("Index", new string[] { $"Array Total: {priceTotal:C2}" });




             /*Dictionary<string, Product> products = new Dictionary<string, Product>
             {
                 ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
                 ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
             };
             return View("Index", products.Keys);*/

            //decimal cartTotal = cart.TotalPrices();
            //return View("Index", new string[] { $"Total: {cartTotal:C2}" });

            //return View(new string[] { "C#", "Language", "Features" });
            /*List<string> results = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                string category = p?.Category ?? "<No Category>";
                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}, Category:{category}");

                //results.Add(string.Format("Name: {0}, Price: {1}", name, price)); same way to code same thing below
                 //results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            }
            return View(results);*/
        }

    }
}
/*------------------------------------------MyExtensionMethods.cs---------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)

        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productEnum,
decimal minimumPrice)

        {

            foreach (Product prod in productEnum)

            {

                if ((prod?.Price ?? 0) >= minimumPrice)

                {
                    yield return prod;
                }
            }
        }
        public static IEnumerable<Product> FilterByName(
            this IEnumerable<Product> productEnum, char firstLetter)
        {
            foreach (Product prod in productEnum)
            {
                if (prod?.Name?[0] == firstLetter)
                {
                    yield return prod;
                }
            }
        }
        public static IEnumerable<Product> Filter(this IEnumerable<Product> productEnum, Func<
            Product, bool> selector)
        {
            foreach (Product prod in productEnum)
            {
                if (selector(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}
/*-----------------------------------Products.cs-------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }

        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }


        public static Product[] GetProducts()
        {

            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };
            Product lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }
    }
}
/*----------------------------------ShoppingCart.cs-----------------------------*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class ShoppingCart : IEnumerable<Product>
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
/*-----------------------------Program.cs-------------------------------------*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LanguageFeatures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
/*-------------------------Startup.cs-------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace LanguageFeatures
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvcWithDefaultRoute();
        }
    }
}
