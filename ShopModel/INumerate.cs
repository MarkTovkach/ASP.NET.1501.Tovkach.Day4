using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    interface INumerate
    {
        public decimal ValueProducts(IEnumerable<Product> products);
        
    }
}
