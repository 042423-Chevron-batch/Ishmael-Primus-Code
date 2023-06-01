using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prj1ApiModels;
using Prj1ApiRepository;


namespace Prj1ApiBusiness
{
    public class Prj1_AppPlay
    {
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
        // public Order CreateOrder(StoreData store, Product product, Customer customer, int quantity)
        // {
        //     Order newOrder = new Order
        //     {
        //         Store = store,
        //         Product = product,
        //         Customer = customer,
        //         Quantity = quantity
        //     };

        //     return newOrder;
        // }

        // Place an order to a store location for a customer
        //
        public static Order PlaceOrder(Store store, Product product, Customer customer, int quantity)
        {
            Order ret = Repository.PlaceOrder(store, product, customer, quantity);
            return ret;
        }

        // Login for the user for repository 
        //
        public static Customer Login ( string fname, string lname)
        {
            Customer ret = Repository.Login(fname, lname);
            return ret;
        }

        // Add a new customer to the repository
        //
        public static Customer AddCustomer(string fname, string lname)
        {
            Customer ret = Repository.AddCustomer(fname, lname);
            return ret;
        }

        // Display customer order history
        //
        public static List<Order> DisplayOrderHistory(Customer customer)
        {
            List<Order> ret = Repository.DisplayOrderHistory(customer);
            return ret;
        }

        // Display order history of a specific store
        //
        public static List<Order> DisplayOrderHistory(Store store)
        {
            List<Order> ret = Repository.DisplayOrderHistory(store);
            return ret;
        }
        
        // Update the product quantity in the store
        //
        static void UpdateProductQuantity(StoreData store, Product product, int quantity)
        {
            product.Quantities[store] -= Repository.UpdateProductQuantity( product, store, quantity );
        }

        /// <summary>
        ///  send a string with customer fname, and lname spearated by a space.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Customer RegisterCustomer(string x)
        {
            string[] xx = x.Split(' ');

            if (xx.Length >= 3 && Int32.TryParse(xx[2], out int xx1))
            {
                return new Customer(xx[0], xx[1]);
            }
            else
            {
                return new Customer(xx[0], "Primus");
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


    }// EoC
}// EoN

// 6/1 Added CustomerLogin method, AddCustomer method, DisplayOrderHistory method, EvaluateOrder method, and PlaceOrder method


