using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    interface IDiscount
    {
        decimal ApplyDiscount(decimal startValue, int percent);
    }
}
