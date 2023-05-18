using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//  Allows me to C=create instances of the Order class with unique order IDs and the current date and time
namespace P1
{
    public class Order
    {
        public Guid OrderId { get; set; } = Guid.NewGuid();
        public Customers Customer { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Stores Store { get; set; }
        public Locations Location { get; set; }

    }
}
