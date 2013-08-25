using DinnerManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DinnerManager.Models
{
    public class CreateMealViewModel
    {
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime Date { get; set; }
        public IEnumerable<Dish> Dishes { get; set; }
        public int SelectedDishId { get; set; }
    }
}