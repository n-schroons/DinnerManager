using DinnerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestdataBuilder
{
    internal class DishBuilder : ITestdataBuilder<Dish>
    {
        private Dish _dish;

        public DishBuilder()
        {
            this._dish = new Dish
            {
                Name = "Standaard test gerecht",
                Rating = 4
            };
        }

        public DishBuilder WithName(string name)
        {
            this._dish.Name = name;
            return this;
        }

        public DishBuilder WithRating(int rating)
        {
            this._dish.Rating = rating;
            return this;
        }

        public DishBuilder WithDescription(string description)
        {
            this._dish.Description = description;
            return this;
        }

        public DishBuilder WithRemarks(string remarks)
        {
            this._dish.Remarks = remarks;
            return this;
        }

        public Dish Build()
        {
            return _dish;
        }
    }
}
