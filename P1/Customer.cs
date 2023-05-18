using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//  Defines a Customer class with properties for the first name (Fname) and last name (Lname). 
// The first name property has a custom validation that throws a FormatException if the name length is less than 4 characters.
namespace P1
{
    public class Customer
    {

        public Customer() { }

        public Customer(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        }


        private string fname;
        public string Fname
        {
            get { return fname; }
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
