using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1
{
    public class Store
    {
        public Store(int storeId, string location)
        {
            StoreId = storeId;
            Location = location;
        }
        public int StoreId { get; set; }
        public string Location { get; set; }
    }
}
