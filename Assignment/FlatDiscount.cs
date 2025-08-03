using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FlatDiscount : Discount
    {
        public decimal FlatAmount { get; set; }

        public FlatDiscount(decimal flatAmount) : base("Flat Discount")
        {
            FlatAmount = flatAmount;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(quantity, 1);
        }
    }
}
