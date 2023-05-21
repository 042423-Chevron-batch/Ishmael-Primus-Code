using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace P1
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public Product(int ProductId, string Name, decimal Price, string Description, int Quantity)
        {
            this.ProductId = ProductId;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
            this.Quantity = Quantity;
        }
    }
}
