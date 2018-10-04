/*----(Controllers)HomeController.cs----------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVisualStudio.Models;


namespace WorkingWithVisualStudio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(SimpleRepository.SharedRepository.Products
            .Where(p => p?.Price < 50));
    }
}
/*--------(Models)Product.cs-----------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WorkingWithVisualStudio.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
/*--------(Models)SimpleRepository.cs---------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products
            = new Dictionary<string, Product>();
        public static SimpleRepository SharedRepository => sharedRepository;
        public SimpleRepository()
        {
            var initialItems = new[] {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M }
            };
            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
            products.Add("Error",
                null);
        }
        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
/*----------(Views)Index.cshtml------------*/

@model IEnumerable<WorkingWithVisualStudio.Models.Product>
@{
    Layout = null;
}
<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>WorkingWithVisualStudio</title>
    <link rel="stylesheet" href="css/bundle.min.css" />
    <script src="js/bundle.min.js"></script>
</head>
<body>
<h3>Products</h3>
<p>Request Time: @DateTime.Now.ToString("HH:mm:ss")</p>
<table>
    <thead>
    <tr><td>Name</td><td>Price</td></tr>
    </thead>
    <tbody>
    @foreach (var p in Model)
    {
        <tr>
            <td> @p.Name </td>
            <td> @($"{p.Price:C2}") </td>
        </tr>
    }
    </tbody>
</table>
</body>
</html>
/*---------(Program)Program.cs----------------*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WorkingWithVisualStudio
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
/*-------------(Program)Startup.cs------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace WorkingWithVisualStudio
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseBrowserLink();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

        }
    }
}
