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

        public List<Store> GetStores()
        {
            Repository repo = new Repository();
            List<Store> stores = repo.GetStores();
            if (stores.Count > 0)
            {
                return stores;
            }
            else
            {
                return null;
            }
        }

        public Customer Login(string username, string password)
        {
            Repository repo = new Repository();
            
            // send the username and password to repo layer.
            Customer c = repo.GetUserByUnamePword(username, password);
            return c;
        }

        public Customer Register(RegisterDto dto)
        {
            // 1. do someting to the data if necessary.
            //UserNamePasswordInDb
            Repository repo = new Repository();
            // 2. call a repo layer method to check if the username/password combo is in the DB.
            // 1st call to repo layer
            bool ret = repo.UserNamePasswordInDb(dto.UserName, dto.Password);
            if (!ret)
            {
                //create a new Person object to get a GUID id.
                //2nd call to repo layer
                Customer c = Mapper.RegisterDtoToPerson(dto);

                // 3. call a repo layer method to put this data into the Db.
                // 3rd call to repo layer
                int numRowsAffected = repo.RegisterNewCustomer(p);
                if (numRowsAffected == 1)
                {
                    //call another repo method that will get a person by usernames and password
                    //4th call to repo layer
                    Customer c1 = repo.GetUserByUnamePword(c.UserName, c.Password);
                    return c1;
                }
            }
            return null;
        }

        public Store StoreInfo(Guid storeId)
        {
            Repository repo = new Repository();
            Store s = repo.StoreInfo(storeId);
            if (s != null) return s;
            else return null;
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



