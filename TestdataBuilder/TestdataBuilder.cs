using DinnerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestdataBuilder
{
    public class TestdataBuilder
    {
        public void Build()
        {
            using (var context = new DinnerManagerContext("DinnerManager"))
            {
                var spaghetti = new DishBuilder().WithDescription("Annick's befaamde spaghetti")
                                                 .WithName("Spaghetti bolognaise")
                                                 .WithRating(5)
                                                 .Build();
                context.Dishes.Add(spaghetti);

                context.SaveChanges();
            }
        }
    }
}
