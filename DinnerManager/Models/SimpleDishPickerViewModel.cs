using DinnerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DinnerManager.Models
{
    public class SimpleDishPickerViewModel
    {
        public int SelectedDishId { get; set; }
        public IEnumerable<Dish> Dishes { get; set; }
    }
}