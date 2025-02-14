using System.Data.SqlClient;

namespace Lab.Pages.DB
{
    public class DBClass
    {
        // Use this class to define methods that make connecting to
        // and retrieving data from the DB easier.

        // Connection Object at Data Field Level
        public static SqlConnection GroceryDBConnection = new SqlConnection();

        // Connection String - How to find and connect to DB
        private static readonly String? GroceryDBConnString = 
            "Server=Localhost;Database=Grocery;Trusted_Connection=True";

        //Connection Methods:

        //Basic Product Reader
        public static SqlDataReader ProductReader()
        {
            SqlCommand cmdProductRead = new SqlCommand();
            cmdProductRead.Connection = GroceryDBConnection;
            cmdProductRead.Connection.ConnectionString = GroceryDBConnString;
            cmdProductRead.CommandText = "SELECT * FROM Product";
            cmdProductRead.Connection.Open(); // Open connection here, close in Model!

            SqlDataReader tempReader = cmdProductRead.ExecuteReader();

            return tempReader;
        }
    }
}
