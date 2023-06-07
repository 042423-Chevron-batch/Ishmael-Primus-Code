using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prj1_Models
{
    public class Store
    {
        public Store(Guid id, string name, string addy)
        {
            this.StoreId = id;
            this.Address = addy;
            this.Name = name;
        }

        public Guid StoreId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public List<Product>? Inventory { get; set; } = new List<Product>();// we will need to keep the quantity of that product on the product instance itself.

    }
}
// {
//     public enum Store
//     {
//         Walmart = 1,
//         Kroger = 2,
//         HEB = 3,
//     }
//     public class StoreData
//     {
//         public Guid StoreId { get; set; } = Guid.NewGuid();
//         public string Name { get; set; }
//         public StoreData Store { get; set; }


//         public StoreData(Guid storeId, String name)
//         {
//             StoreId = storeId;
//             Name = name;
//         }
    
//     }
//     /// <summary>
//     /// This class is used to store the store location
//     /// </summary>
//     public static class StoreLocation
//     {
//         public static string GetStoreLocation(StoreData store)

//         {
//             switch (store.Name)
//             {
//                 case "Walmart":
//                     return "Houston";
//                 case "Kroger":
//                     return "Sugar Land";
//                 case "HEB":
//                     return "Cypress";
//                 default:
//                     throw new ArgumentException("Invalid store.");
//             }
//         }
//     }
// }