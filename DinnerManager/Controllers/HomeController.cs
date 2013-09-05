using DinnerManager.Entities;
using DinnerManager.Models;
using Newtonsoft.Json;
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
            return View();
        }

        public ContentResult GetMeals()
        {
            using (var context = new DinnerManagerContext())
            {
                var viewModels = new List<IndexViewModel>();
                foreach (var m in context.Meals)
                {
                    viewModels.Add(new IndexViewModel
                    {
                        Id = m.Id,
                        Date = m.Date,
                        Name = m.Dish.Name,
                        Rating = m.Dish.Rating
                    });
                }

                var meals = JsonConvert.SerializeObject(viewModels);

                return Content(meals, "application/json");
            }
        }

        public JsonResult UpdateMeal(int id, DateTime start)
        {
            using (var context = new DinnerManagerContext())
            {
                try
                {
                    var meal = context.Meals.Single(m => m.Id == id);
                    meal.Date = start;

                    context.SaveChanges();

                    return Json(new { success = true });
                }
                catch (Exception)
                {
                    return Json(new { success = false, message = "Er liep iets mis bij het opslaan van de nieuwe datum" });
                }
            }
        }
    }
}
