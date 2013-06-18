using DinnerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DinnerManager.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            using (var context = new DinnerManagerContext("DinnerManager"))
            {
                return View(context.Dishes.ToList());
            }
        }

    }
}
