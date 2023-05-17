using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1
{
    public class Person
    {


        public Person() { }

        public Person(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        }

        public long PersonId { get; private set; }

        private string fname;
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                try
                {
                    if (value.Length < 4)
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        this.fname = value;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid name format. Please try again.");
                }
            }
        }

        public string Lname { get; set; }
    }
}

