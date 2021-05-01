using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMarket.Models
{
    public class Food
    {
        [Required]
        [Key]
        [StringLength(15)]
        public string Barcode { get; set; }

        [Required]
        public string BrandName { get; set; }

        public RefFood RefFood { get; set; }
        [Required]
        [Display(Name = "Food Type Name")]
        public byte FoodTypeId { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }

        [Required]
        public DateTime ExpityDate { get; set; }
    }
}