using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMarket.Models
{
    public class Market
    {
        [Key]
        [Required]
        public int TransactionID { get; set; }

        public Food Food { get; set; }
        [StringLength(15)]
        [Required]
        public string Barcode { get; set; }

        [Required]
        public int QuantitySold { get; set; }

        [Required]
        public DateTime DateTimeSold { get; set; }

        [Required]
        public float TotalPrice { get; set; }
    }
}