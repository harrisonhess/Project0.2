using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace Project0._2.Models
{
    public class Opportunity
    {
        [HiddenInput]
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter opportunity name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter opportunity center")]
        public string Center { get; set; }
        [Required(ErrorMessage = "Please enter opportunity date")]
        public string Date { get; set; }
    }
}
