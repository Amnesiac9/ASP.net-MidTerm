using john_moreau_MidTerm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

/*
* John Moreau
* CSS233
* 10/28/2023
*
*
*/

namespace john_moreau_MidTerm.Controllers
{
    public class ProductController : Controller
    {


        private SportsContext Context { get; set; }

        public ProductController(SportsContext ctx) => Context = ctx;

        public IActionResult List(string sortBy, string sortOrder)
        {
            var products = Context.Products;

            switch (sortBy)
            {
                case "Code":
                    ViewData["CodeSortOrder"] = sortOrder;
                    return sortOrder switch
                    {
                        "asc" => View(products.ToList()),
                        "desc" => View(products.OrderByDescending(m => m.Code).ToList()),
                        _ => View(products.OrderBy(m => m.ProductId).ToList()),
                    };
                case "Name":
                    ViewData["NameSortOrder"] = sortOrder;
                    return sortOrder switch
                    {
                        "asc" => View(products.OrderBy(m => m.Name).ToList()),
                        "desc" => View(products.OrderByDescending(m => m.Name).ToList()),
                        _ => View(products.OrderBy(m => m.ProductId).ToList()),
                    };
                case "Price":
                    ViewData["PriceSortOrder"] = sortOrder;
                    return sortOrder switch
                    {
                        "asc" => View(products.OrderBy(m => m.Price).ToList()),
                        "desc" => View(products.OrderByDescending(m => m.Price).ToList()),
                        _ => View(products.OrderBy(m => m.ProductId).ToList()),
                    };
                case "ReleaseDate":
                    ViewData["ReleaseDateSortOrder"] = sortOrder;
                    return sortOrder switch
                    {
                        "asc" => View(products.OrderBy(m => m.ReleaseDate).ToList()),
                        "desc" => View(products.OrderByDescending(m => m.ReleaseDate).ToList()),
                        _ => View(products.OrderBy(m => m.ProductId).ToList()),
                    };
                default:
                    return View(products.OrderBy(m => m.ProductId).ToList());

            }
        }
    }
}
