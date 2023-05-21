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
<<<<<<< HEAD
        public Dictionary<StoreData, int> Quantities { get; set; }

        public Product(int ProductId, string Name, decimal Price, string Description, Dictionary<StoreData, int> quantities)
=======
<<<<<<< HEAD
        public Dictionary<Store, int> Quantities { get; set; }

        public Product(int ProductId, string Name, decimal Price, string Description, Dictionary<Store, int> quantities)
=======
        public int Quantity { get; set; }

        public Product(int ProductId, string Name, decimal Price, string Description, int Quantity)
>>>>>>> main
>>>>>>> 833a58370d7e91f36a33f42201c7fdd2941ce319
        {
            this.ProductId = ProductId;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
<<<<<<< HEAD
            this.Quantities = quantities;
=======
            this.Quantity = Quantity;
>>>>>>> main
        }
    }
}
