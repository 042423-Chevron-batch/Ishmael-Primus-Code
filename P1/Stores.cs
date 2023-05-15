using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1
{
    public class Stores
    {
        public string Store { get; set;  }
        // a constructor is public, it is the name of of the class, it has a body where setup actions are done.
        public Stores(string store)
        {
            Store = store;
        }
    }
}
