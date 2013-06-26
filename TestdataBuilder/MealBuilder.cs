using DinnerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestdataBuilder
{
    internal class MealBuilder : ITestdataBuilder<Meal>
    {
        private Meal _meal;

        public MealBuilder()
        {
            this._meal = new Meal
            {
                Date = DateTime.Now,
                Dish = new DishBuilder().Build()
            };
        }

        public MealBuilder WithDate(DateTime date)
        {
            this._meal.Date = date;
            return this;
        }

        public MealBuilder WithDish(Dish dish)
        {
            this._meal.Dish = dish;
            return this;
        }

        public Meal Build()
        {
            return _meal;
        }
    }
}
