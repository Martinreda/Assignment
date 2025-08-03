using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }

        public PercentageDiscount(decimal percentage) : base("Percentage Discount")
        {
            Percentage = percentage;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100);
        }
    }
}
