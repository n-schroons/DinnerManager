using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DinnerManager.Models
{
    public class IndexViewModel
    {
        [DisplayFormat(DataFormatString = "{0:dddd dd MMMM}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
    }
}