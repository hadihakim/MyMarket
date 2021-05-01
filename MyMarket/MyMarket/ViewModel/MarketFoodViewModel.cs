using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyMarket.Models;

namespace MyMarket.ViewModel
{
    public class MarketFoodViewModel
    {
        public IEnumerable<RefFood> RefFoods { get; set; }

        public Market Market { get; set; }
    }
}