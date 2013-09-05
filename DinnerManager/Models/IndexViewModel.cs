using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DinnerManager.Models
{
    public class IndexViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("start")]
        public DateTime Date { get; set; }

        [JsonProperty("title")]
        public string Name { get; set; }
        
        public int Rating { get; set; }
    }
}