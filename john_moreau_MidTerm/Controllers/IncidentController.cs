//using john_moreau_MidTerm.Migrations;
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
    public class IncidentController : Controller
    {
        private SportsContext Context { get; set; }
        public IncidentController(SportsContext ctx) => Context = ctx;

        public IActionResult List(string sortBy, string sortOrder)
        {
            var incidents = Context.Incidents.Include(c => c.Customer).Include(c => c.Product);
            //var countries = Context.Countries.ToList();

            switch (sortBy)
            {
                case "Title":
                    ViewData["TitleSortOrder"] = sortOrder;
                    return sortOrder switch
                    {
                        "asc" => View(incidents.OrderBy(m => m.Title).ToList()),
                        "desc" => View(incidents.OrderByDescending(m => m.Title).ToList()),
                        _ => View(incidents.OrderBy(m => m.Id).ToList()),
                    };
                case "Customer":
                    ViewData["CustomerSortOrder"] = sortOrder;
                    return sortOrder switch
                    {
                        "asc" => View(incidents.OrderBy(m => m.Customer == null ? "" : m.Customer.FirstName).ToList()),
                        "desc" => View(incidents.OrderByDescending(m => m.Customer == null ? "" : m.Customer.FirstName).ToList()),
                        _ => View(incidents.OrderBy(m => m.Id).ToList()),
                    };
                case "Product":
                    ViewData["ProductSortOrder"] = sortOrder;
                    return sortOrder switch
                    {
                        "asc" => View(incidents.OrderBy(m => m.Product == null ? "" : m.Product.Name).ToList()),
                        "desc" => View(incidents.OrderByDescending(m => m.Product == null ? "" : m.Product.Name).ToList()),
                        _ => View(incidents.OrderBy(m => m.Id).ToList()),
                    };
                case "DateOpened":
                    ViewData["DateOpenedSortOrder"] = sortOrder;
                    return sortOrder switch
                    {
                        "asc" => View(incidents.OrderBy(m => m.DateOpened).ToList()),
                        "desc" => View(incidents.OrderByDescending(m => m.DateOpened).ToList()),
                        _ => View(incidents.OrderBy(m => m.Id).ToList()),
                    };
                default:
                    return View(incidents.OrderBy(m => m.Id).ToList());

            }
        }


        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Customers = Context.Customers.ToList();
            ViewBag.Products = Context.Products.ToList();
            ViewBag.Technicians = Context.Technicians.ToList();
            ViewBag.Action = "Add";
            return View("Edit", new Incident());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var incident = Context.Incidents.Find(id);
            ViewBag.Customers = Context.Customers.ToList();
            ViewBag.Products = Context.Products.ToList();
            ViewBag.Technicians = Context.Technicians.ToList();
            ViewBag.Action = "Edit";
            return View(incident);
        }

        [HttpPost]
        public IActionResult Edit(Incident incident)
        {
            if (ModelState.IsValid)
            {
                if (incident.Id == 0)
                {
                    incident.DateOpened = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
                    Context.Incidents.Add(incident);

                }
                else
                {
                    Context.Incidents.Update(incident);
                }

                Context.SaveChanges();
                return RedirectToAction("List", "Incident");

            }
            else
            {
                ViewBag.Customers = Context.Customers.ToList();
                ViewBag.Products = Context.Products.ToList();
                ViewBag.Technicians = Context.Technicians.ToList();
                ViewBag.Action = (incident.Id == 0) ? "Add" : "Edit";
                if (incident.Id == 0)
                {
                    return View("Edit", incident);
                }
                else
                {
                    return View(incident);
                }

            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var incident = Context.Incidents.Find(id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            Context.Incidents.Remove(incident);
            Context.SaveChanges();
            return RedirectToAction("List", "Incident");
        }
    }
}
