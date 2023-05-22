namespace Prj1ApiModels
{
    public enum Store
    {
        Walmart = 1,
        Kroger = 2,
        HEB = 3,
    }
    public class StoreData
    {
        public Guid StoreId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public StoreData Store { get; set; }


        public StoreData(Guid storeId, String name)
        {
            StoreId = storeId;
            Name = name;
        }
    }
    /// <summary>
    /// This class is used to store the store location
    /// </summary>
    public static class StoreLocation
    {
        public static string GetStoreLocation(StoreData store)

        {
            switch (store.Name)
            {
                case "Walmart":
                    return "Houston";
                case "Kroger":
                    return "Sugar Land";
                case "HEB":
                    return "Cypress";
                default:
                    throw new ArgumentException("Invalid store.");
            }
        }
    }
}