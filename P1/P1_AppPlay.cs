using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// this is a business layer class
[assembly: InternalsVisibleTo("Tests.P1")]

namespace P1
{
    internal class P1_AppPlay
    {
        private static List<App> AllApps { get; set; } = new List<App>();

        /// <summary>
        /// This method takes an int and a double and returns a string concatenation of them
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static string TestDemoMethod(int x, double y)
        {
            string ret = $"{x} {y}";
            return ret;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="store"></param>
        /// <param name="product"></param>
        /// <param name="customer"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>/
        public Order CreateOrder(StoreData store, Product product, Customer customer, int quantity)
        {
            Order newOrder = new Order
            {
                Store = store,
                Product = product,
                Customer = customer,
                Quantity = quantity
            };

            return newOrder;
        }

        /// <summary>
        ///  send a string with customer fname, and lname spearated by a space.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Customer RegisterCustomer(string x)
        {
            string[] xx = x.Split(' ');

            if (Int32.TryParse(xx[2], out int xx1))
            {
                return new Customer(xx[0], xx[1]);
            }
            else
            {
                return new Customer(xx[0], xx[1]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        /// 
        public static Store? ValidateUserInput(string st)
        {
            string st1 = st.ToUpper();
            if (st1 != "")
            {
                if (st1[0].Equals('W'))
                {
                    return Store.Walmart;
                }
                else if (st1[0].Equals('K'))
                {
                    return Store.Kroger;
                }
                else if (st1[0].Equals('H'))
                {
                    return Store.HEB;
                }
            }
            return null;
        }
    }
}


