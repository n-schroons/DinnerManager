using DinnerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DinnerManager.Models
{
    public class CreateMealViewModel
    {
        public DateTime Date { get; set; }
        //public SimpleDishPickerViewModel SimpleDishPickerViewModel { get; set; }
        public IEnumerable<Dish> Dishes { get; set; }
        public int SelectedDishId { get; set; }
    }
}