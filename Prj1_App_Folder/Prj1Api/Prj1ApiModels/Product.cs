using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prj1ApiModels
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Dictionary<StoreData, int> Quantities { get; set; }

        public Product(Guid ProductId, string Name, decimal Price, string Description, Dictionary<StoreData, int> quantities)
        {
            this.ProductId = ProductId;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
            this.Quantities = quantities;
        }
    }
}
