﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class ShoppingCart
    {
        private INumerate valueCalc;

      
        public IEnumerable<Product> Products { get; set; }

        public ShoppingCart(INumerate valueCalc)
        {
            this.valueCalc = valueCalc;
            
        }

        public decimal CalculateProductTotal()
        {
            return valueCalc.ValueProducts(Products);
        }
    }
}
