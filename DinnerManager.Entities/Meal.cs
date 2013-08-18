using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerManager.Entities
{
    public class Meal
    {
        public int Id { get; set; }
        
        [Required]
        public DateTime Date { get; set; }

        public virtual Dish Dish { get; set; }
    }
}
