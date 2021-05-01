using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMarket.Models
{
    public class RefFood
    {
        [Required]
        [Key]
        public byte FoodTypeId { get; set; }

        [Required]
        [Display(Name = "Food Type Name")]
        public string FoodTypeName { get; set; }
    }
}