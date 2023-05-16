using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1
{
    public class App
    {
        public Guid AppId { get; set; } = Guid.NewGuid();
        public DateTime AppDate { get; set; } = DateTime.Now;
        public List<Select> Selects { get; set; } = new List<Select>();
    }
}
