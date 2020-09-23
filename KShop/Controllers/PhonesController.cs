using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KShop.Controllers
{
    public class PhonesController : Controller
    {
        // GET: Phones
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create() {
            return View();
        }

        public ActionResult Edit(int id) {
            return View();
        }
    }
}