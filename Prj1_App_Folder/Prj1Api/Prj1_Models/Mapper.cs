using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prj1_Models;

namespace Prj1_Models
{
    public class Mapper
    {
        /// <summary>
        /// this method will take a RegisterDto object and convert it to a Person object, using the Guid that the Person object is given automatically.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public static Person RegisterDtoToPerson(RegisterDto dto)
        {
            return new Person(dto.FirstName, dto.LastName, dto.LastOrderDate, dto.Remarks, dto.UserName, dto.Password);
        }

        /// <summary>
        /// This method will take the next row of a SqlDatReader for a product in inventory and return a Product
        /// </summary>
        /// <param name="res"></param>
        /// <returns></returns>
        public static Product AdoToProduct(Guid id, string name, int price, string desc, Dictionary<StoreData, int> quantities)
        {
            Product p = new Product(id, name, price, desc, quantities);
            return p;
        }

        public static Store AdoToStore(Guid guid, string v1, string v2)
        {
            return new Store(guid, v1, v2);
        }
    }
}