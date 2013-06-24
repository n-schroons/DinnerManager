using DinnerManager.Entities;
using DinnerManager.Models;
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
                var meals = context.Meals.ToList();
                var viewmodels = new List<IndexViewModel>();

                foreach (var m in meals)
                {
                    viewmodels.Add(new IndexViewModel
                    {
                        Date = m.Date.d,
                        Name = m.Dish.Name,
                        Rating = m.Dish.Rating
                    });
                }

                return View(viewmodels);
            }
        }

    }
}
