using DinnerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestdataBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DinnerManagerContext("DinnerManager"))
            {
                foreach (var dish in context.Dishes)
                {
                    context.Dishes.Remove(dish);
                }

                context.Dishes.Add(new Dish
                {
                    Description = "Spaghetti op Annick's wijze",
                    Name = "Spaghetti bolognaise",
                    Rating = 5,
                    Remarks = "Veel groenten!"
                });

                context.Dishes.Add(new Dish
                {
                    Description = string.Empty,
                    Name = "Kriekjes met gehaktbrood",
                    Rating = 4,
                    Remarks = "Volgende keer langer in de oven"
                });

                context.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
