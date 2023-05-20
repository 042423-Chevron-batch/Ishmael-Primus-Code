using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 'APP' CLASS THAT INCLUDES PROPERTIES FOR APPID, APPDATE AND ORDERS
namespace P1
{
    public class App
    {
        public Guid AppId { get; set; } = Guid.NewGuid();
        public DateTime AppDate { get; set; } = DateTime.Now;
        public List<Order> Orders { get; set; } = new List<Order>();

    }
}