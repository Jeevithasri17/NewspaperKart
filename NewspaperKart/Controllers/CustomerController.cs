using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewspaperKart.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<Newspaper> newspapers = new List<Newspaper>();


        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult CustomerList()
        {
            using (var db = new NewspaperkartContext())
            {
                customers = db.Customers.ToList();
            }
            return View(customers);
        }

        public IActionResult AddCustomer()
        {
            ViewData["Id"] = new SelectList(newspapers, "Id", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer e)
        {
            ViewData["Id"] = new SelectList(newspapers, "Id", "Title");

            using (var db = new NewspaperkartContext())
            {
                db.Customers.Add(e);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Payment");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Customer e = new Customer();
            using (var db = new NewspaperkartContext())
            {
                e = db.Customers.Find(id);
            }
            return View(e);
        }

        [HttpPost]
        public IActionResult Edit(Customer e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

            }
            return RedirectToAction("CustomerList");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Customer e = new Customer();
            using (var db = new NewspaperkartContext())
            {
                e = db.Customers.Find(id);
                //db.Subscriptions.Remove(e);
                //db.SaveChanges();
            }
            return View(e);
        }


        [HttpPost]
        public IActionResult Delete(Customer e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Customers.Remove(e);
                db.SaveChanges();
            }

            return RedirectToAction("CustomerList");
        }

        public IActionResult MySubscription()
        {
            using (var db = new NewspaperkartContext())
            {
                customers = db.Customers.ToList();
            }
            return View(customers);
        }

        [HttpGet]
        public IActionResult DeleteSubscription(int id)
        {
            Customer e = new Customer();
            using (var db = new NewspaperkartContext())
            {
                e = db.Customers.Find(id);
                //db.Subscriptions.Remove(e);
                //db.SaveChanges();
            }
            return View(e);
        }


        [HttpPost]
        public IActionResult DeleteSubscription(Customer e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Customers.Remove(e);
                db.SaveChanges();
            }

            return RedirectToAction("MySubscription");
        }

    }
}
