using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    public class RetrieveInsertedDataProgram
    {
        static void Main(string[] args)
        {
            new RetrieveInsertedDataProgram().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=DESKTOP-1ID32BM\\SQLEXPRESS; database=Student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("Select * from student", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]); // Displaying Record  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}