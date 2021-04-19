using Jewelry_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_Store.Helpers
{
    public static class CalculateTotalDiscountPrice
    {
        public static double CalculateTotalDiscount(Jwelry jwelry)
        {
             double afterDiscountPrice = 0;
            if (jwelry != null)
            {
                var totalPrice = jwelry.GoldPricePerGram * jwelry.GoldWeightInGram;
                var discountPrice = (totalPrice * jwelry.DiscountPercentage) / 100;
                afterDiscountPrice = (totalPrice - discountPrice);
            }
            return afterDiscountPrice;
        }
    }
}
