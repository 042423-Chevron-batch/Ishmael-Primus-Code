using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Select
{
    public class Select
    {
        // a constructor is public, it is the same name of the class, it has a body where setup actions are done.
        public Select(Person SelectUser)
        {
            this.SelectDate = DateTime.Now;
            this.SelectUser = SelectUser;
        }

        public DateTime SelectDate { get; set; }
        public Person SelectUser { get; set; }

    }
}