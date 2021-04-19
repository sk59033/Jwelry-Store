using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_Store.Models
{
    public class Jwelry
    {
        public int Id { get; set; }
        public double GoldPricePerGram { get; set; }
        public double GoldWeightInGram { get; set; }
        public double TotalPrice { get; set; }
        public double DiscountPercentage { get; set; }
        public int UserId { get; set; }
    }
}
