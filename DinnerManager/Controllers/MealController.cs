using DinnerManager.Entities;
using DinnerManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DinnerManager.Controllers
{
    public class MealController : Controller
    {
        //
        // GET: /Meal/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            using (var context = new DinnerManagerContext())
            {
                var dishes = context.Dishes.ToList();

                return View(new CreateMealViewModel
                {
                    Date = DateTime.Now.Date,
                    Dishes = dishes,
                    SelectedDishId = dishes.First().Id
                }); 
            }
        }

        [HttpPost]
        public ActionResult Create(CreateMealViewModel m)
        {
            using (var context = new DinnerManagerContext())
            {
                context.Meals.Add(new Meal
                    {
                        Date = m.Date,
                        Dish = context.Dishes.Single(d => d.Id == m.SelectedDishId)
                    });
                context.SaveChanges();
            }
            
            return RedirectToAction("Index", "Home");
        }
    }
}
