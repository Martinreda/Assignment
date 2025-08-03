using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class NoDiscount : Discount
    {
        public NoDiscount() : base("No Discount") { }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return 0;
        }
    }
}
