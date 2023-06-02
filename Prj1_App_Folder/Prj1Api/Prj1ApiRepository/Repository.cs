using System.Data.SqlClient;
using Prj1ApiModels;

namespace Prj1ApiRepository
{
    public class Repository
    {
        //here we will write the ADO.NET code to access the Database.
        //Server=tcp:052123-batch-server.database.windows.net,1433;
        //Initial Catalog=052123-batch-db;Persist Security Info=False;User 
        //ID=batch052123;Password={your_password};
        //MultipleActiveResultSets=False;Encrypt=True;
        //TrustServerCertificate=False;Connection Timeout=30;
        private static SqlConnection con { get; set; } = new SqlConnection("Server=tcp:052123-batch-server.database.windows.net,1433; Initial Catalog=052123-batch-db;Persist Security Info=False;User ID=batch052123;Password=Nubian19;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        public static int Test(string fname, string lname)
        {
            SqlCommand comm = new SqlCommand("INSERT INTO Customer1 (FirstName, LastName) VALUES (@fname, @lname);", con);
            comm.Parameters.AddWithValue("@fname", fname);
            comm.Parameters.AddWithValue("@lname", lname);
      //    comm.Parameters.AddWithValue("@email", email);
            con.Open();
            int res = 0;
            try
            {
                res = comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // write this exception to a file, exception.
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
            }
            Console.WriteLine($"The value is =>{res}.");
            return res;
        }

        // SELECT CustomerId, FirstName, LastName, Email FROM [dbo].[Customer] WHERE FirstName = 'James Alan' AND LastName = 'Moore'; 
        public static Customer Login(string fname, string lname)
        {
            SqlCommand comm = new SqlCommand("INSERT INTO Customer1 (FirstName, LastName) VALUES (@fname, @lname);", con);
            comm.Parameters.AddWithValue("@fname", fname);
            comm.Parameters.AddWithValue("@lname", lname);
            con.Open();
            SqlDataReader ret = comm.ExecuteReader();

            Customer c = new Customer();
            //List<Person> myList = new List<Person>();
            // this while loop will iterate over all the rows in the return. You will need to store all the rows in a List<Person>
            while (ret.Read())
            {
                c = new Customer(ret.GetString(1), ret.GetString(2));
                //myList.Add(new Person(ret.GetInt32(0), ret.GetString(1), ret.GetString(2), ret.GetString(3)));
            }
            return c;
        }


        //get all the customers (example)
        public static List<Customer> GetCustomers(string fname, string lname)
        {
            SqlCommand comm = new SqlCommand("SELECT CustomerId, FirstName, LastName, Email FROM [dbo].[Customer];", con);
            con.Open();
            SqlDataReader ret = comm.ExecuteReader();

            List<Customer> myList = new List<Customer>();
            // this while loop will iterate over all the rows in the return. You will need to store all the rows in a List<Customer>
            while (ret.Read())
            {
                myList.Add(new Customer(ret.GetString(1), ret.GetString(2)));
            }
            return myList;
        }

        // Order history for a store location
        //
        public static List<Order> DisplayOrderHistory(StoreData store)
        {
            SqlCommand comm = new SqlCommand("SELECT OrderId, StoreId, ProductId, CustomerId, Quantity FROM [dbo].[Order] WHERE StoreId = @storeId;", con);
            comm.Parameters.AddWithValue("@storeId", store.StoreId);
            con.Open();
            SqlDataReader ret = comm.ExecuteReader();

            List<Order> myList = new List<Order>();
            // this while loop will iterate over all the rows in the return. You will need to store all the rows in a List<Custiner>
            while (ret.Read())
            {
                myList.Add(new Order
                {
                    OrderId = ret.GetGuid(0),
                    Store = store,
                    Quantity = ret.GetInt32(1)
                });

            }
            return myList;
        }

    }
}