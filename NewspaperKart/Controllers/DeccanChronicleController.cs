using Microsoft.AspNetCore.Mvc;
using NewspaperKart.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class DeccanChronicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Subscribe()
        {
            return View();

            
        }

        [HttpPost]

        public IActionResult Subscribe(Subscription e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Subscriptions.Add(e);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Payment");
        }
    }
        
}
