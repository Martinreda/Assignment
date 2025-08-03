using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class PremiumUser : User
    {
        public PremiumUser(string name) : base(name) { }

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
