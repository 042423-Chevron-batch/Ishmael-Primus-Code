using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1
{
    internal class P1_AppFlow
    {
        private static List<App> AllApps { get; set; } = new List<App>();

        /// <summary>
        /// send a string with player fname, lname, and ID-name separated by a space.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Customer RegisterUser(string x)
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
        /// send a string S, W, or C, and receive the equivalent Choices type in return.
        /// The method evaluates the first element in the string.
        /// If the char does not correlate, the method returns null
        /// </summary>
        /// <returns></returns>
        public static Stores? ValidateUserInput(string st)
        {
            string st1 = st.ToUpper();
            if (st1 != "")
            {
                if (st1[0].Equals('W'))
                {
                    return Stores.Walmart;
                }
                else if (st1[0].Equals('K'))
                {
                    return Stores.Kroger;
                }
                else if (st1[0].Equals('h'))
                {
                    return Stores.Return;
                }
            }
            return null;
        }
    }
}
