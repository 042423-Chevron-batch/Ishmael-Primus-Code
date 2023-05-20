using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1
{
    public enum Store
    {
        Walmart = 1,
        Kroger = 2,
        HEB = 3,
    }

    public static class StoreLocator
    {
        public static string GetStoreLocation(Store store)
        {
            switch (store)
            {
                case Store.Walmart:
                    return "Houston";
                case Store.Kroger:
                    return "Sugar Land";
                case Store.HEB:
                    return "Cypress";
                default:
                    throw new ArgumentException("Invalid store.");
            }
        }
    }
}
