using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Udem.EfCore.Data.Context;
using Udem.EfCore.Data.Entities;
using Udem.EfCore.Models;

namespace Udem.EfCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UdemyContext udemyContext = new UdemyContext();

            //TODO: Ekleme
            //var entityEntry = udemyContext.Products.Add(new Product
            //{
            //    Name = "Tablet", Price = 1910
            //});

            // TODO: Güncelleme
            //var updateData = udemyContext.Products.Find(2);
            //if (updateData != null)
            //{
            //    updateData.Name = "huawei";
            //    udemyContext.Products.Update(updateData);
            //}

            //TODO: Silme
            //var deleteData = udemyContext.Products.FirstOrDefault(p => p.Id == 1);
            //if (deleteData != null)
            //{
            //    udemyContext.Products.Remove(deleteData);
            //}

            //Product product = new() { Price = 4000 };
            //udemyContext.Products.Add(product);

            udemyContext.Employees.Add(new FullTimeEmployee
            {
                Firstname = "Furkan", HourlyWage = 480, Lastname = "Turgut"
            });
            udemyContext.Employees.Add(new FullTimeEmployee
            {
                Firstname = "Alperen",
                HourlyWage = 480,
                Lastname = "Turgut"
            });

            udemyContext.Employees.Add(new PartTimeEmployee()
            {
                Firstname = "Mehmet",
                DailyWage = 250,
                Lastname = "Turgut"
            });

            udemyContext.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
