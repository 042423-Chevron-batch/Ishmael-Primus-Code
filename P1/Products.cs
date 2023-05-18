using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 'PRODUCT' CLASS THAT INCLUDES PROPERTIES FOR PRICE, DESCRIPTION, AND PRODUCT

namespace P1
{
    public class Products
    {
        public string Product { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Products(string product, decimal price, string description)
        {
            Product = product;
            Price = price;
            Description = description;
        }
    }
}
