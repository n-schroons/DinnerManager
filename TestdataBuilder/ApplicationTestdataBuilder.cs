using DinnerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestdataBuilder
{
    public class ApplicationTestdataBuilder
    {
        public void Build()
        {
            using (var context = new DinnerManagerContext("DinnerManager"))
            {
                // clear database
                foreach (var m in context.Meals)
                {
                    context.Meals.Remove(m);
                }
                foreach (var d in context.Dishes)
                {
                    context.Dishes.Remove(d);
                }

                var spaghetti = new DishBuilder().WithDescription("Annick's befaamde spaghetti")
                                                 .WithName("Spaghetti bolognaise")
                                                 .WithRating(5)
                                                 .Build();
                context.Dishes.Add(spaghetti);

                var visVidee = new DishBuilder().WithName("Vis videe")
                                                .Build();
                context.Dishes.Add(visVidee);

                var vispannetje = new DishBuilder().WithName("Vispannetje")
                                                   .Build();
                context.Dishes.Add(vispannetje);

                var couscous = new DishBuilder().WithName("Couscous met scampi's")
                                                .Build();
                context.Dishes.Add(couscous);

                var today = new MealBuilder().WithDate(DateTime.Now)
                                             .WithDish(visVidee)
                                             .Build();
                context.Meals.Add(today);

                var tomorrow = new MealBuilder().WithDate(DateTime.Now.AddDays(1))
                                                .WithDish(spaghetti)
                                                .Build();
                context.Meals.Add(tomorrow);

                var dayAfterTomorrow = new MealBuilder().WithDate(DateTime.Now.AddDays(2))
                                                        .WithDish(vispannetje)
                                                        .Build();
                context.Meals.Add(dayAfterTomorrow);

                var sameDayNextWeek = new MealBuilder().WithDate(DateTime.Now.AddDays(7))
                                                         .WithDish(couscous)
                                                         .Build();
                context.Meals.Add(sameDayNextWeek);

                var nextWeek = new MealBuilder().WithDate(DateTime.Now.AddDays(10))
                                                .Build();
                context.Meals.Add(nextWeek);

                context.SaveChanges();
            }
        }
    }
}
