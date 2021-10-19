using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Case.Models;
using System.IO;
using System.Linq;

namespace Case.Controllers
{
    public class HomeController : Controller
    {        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(int ProductID, string Name, string Description){
            string productString = string.Format("{0}, {1}, {2}", ProductID, Name, Description);
            ViewBag.Product = "Indsat " + productString;
            using (StreamWriter swriter = System.IO.File.AppendText(@".\Data\Products.csv")){
               swriter.WriteLine(productString);     
            }
            return View();
        }

        public IActionResult Products(int pageNumber)
        {
            List<Product> products = new List<Product>();
            StreamReader sreader = new StreamReader(@".\Data\Products.csv");
            while(!sreader.EndOfStream) {
                string[] row = sreader.ReadLine().Split(',');

                products.Add(new Product{
                    ProductID = int.Parse(row[0].ToString()),
                    Name = row[1].ToString(),
                    Description = row[2].ToString()
                });
            }
            sreader.Close();

            int pageSize = 10;
            int maxPageNumber = products.Count() / pageSize;
            if (pageNumber == maxPageNumber + 1) {
                pageNumber = maxPageNumber;
                ViewBag.pageNumber = maxPageNumber;
            } else if (pageNumber == -1) {
                pageNumber = 0;
                ViewBag.pageNumber = 0;
            } else {
                ViewBag.pageNumber = pageNumber;
            }
                      
            int exclude = pageSize * pageNumber;
            var result = products.Skip(exclude).Take(pageSize);

            return View(result);        
        }
    }
}
