using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMarket.Models
{
    public class Stock
    {
        [Required]
        [Key]
        public int ItemId { get; set; }
        
        public Food Food { get; set; }
        [Required]
        [StringLength(15)]
        public string Barcode { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float PricePerUnit { get; set; }


    }
}