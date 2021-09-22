using Microsoft.AspNetCore.Mvc;
using NewspaperKart.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{


    public class NewspaperController : Controller
    {

        public static List<Newspaper> newspapers = new List<Newspaper>();

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult NewspaperList()
        {
            using (var db = new NewspaperkartContext())
            {
                newspapers = db.Newspapers.ToList();
            }
            return View(newspapers);
        }

        public IActionResult AddNewspaper()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewspaper(Newspaper e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Newspapers.Add(e);
                db.SaveChanges();
            }
            return RedirectToAction("NewspaperList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Newspaper e = new Newspaper();
            using (var db = new NewspaperkartContext())
            {
                e = db.Newspapers.Find(id);
            }
            return View(e);
        }

        [HttpPost]
        public IActionResult Edit(Newspaper e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

            }
            return RedirectToAction("NewspaperList");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Newspaper e = new Newspaper();
            using (var db = new NewspaperkartContext())
            {
                e = db.Newspapers.Find(id);
                //db.Subscriptions.Remove(e);
                //db.SaveChanges();
            }
            return View(e);
        }


        [HttpPost]
        public IActionResult Delete(Newspaper e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Newspapers.Remove(e);
                db.SaveChanges();
            }

            return RedirectToAction("SubscriptionList");
        }
    }
}
