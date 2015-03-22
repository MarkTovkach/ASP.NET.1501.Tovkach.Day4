using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    class Discounter : IDiscount
    {
        public decimal ApplyDiscount(decimal startValue, int percent)
        {
            decimal changingValue = (decimal) startValue*(1-percent/100) ;
            return changingValue;

        }
    }
}
