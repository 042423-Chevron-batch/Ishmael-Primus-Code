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
        /// This method takes the 
        /// </summary>
        /// <param name="SelectUser"></param>
        /// <returns></returns>
        public static Select RecordSelect(Person SelectUser)
        {
            Select s = new Select(SelectUser);
            return s;
        }
        /// <summary>
        /// send a string with player fname, lname, and ID-name separated by a space.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Person RegisterUser(string x)
        {
            string[] xx = x.Split(' ');

            if (Int32.TryParse(xx[2], out int xx1))
            {
                return new Person(xx[0], xx[1], xx1);
            }
            else
            {
                return new Person(xx[0], xx[1], 111);
            }
        }

         /// <summary>
        /// send a string S, W, or C, and receive the equivalent Choices type in return.
        /// The method evaluates the first element in the string.
        /// If the char does not correlate, the method returns null
        /// </summary>
        /// <returns></returns>
        public static Choices? ValidateUserInput(string st)
        {
            string st1 = st.ToUpper();
            if (st1 != "")
            {
                if (st1[0].Equals('R')) { return Choices.ROCK; }
                else if (st1[0].Equals('P')) { return Choices.PAPER; }
                else if (st1[0].Equals('S')) { return Choices.SCISSORS; }
            }
            return null;
        }

   
    }
    
}


