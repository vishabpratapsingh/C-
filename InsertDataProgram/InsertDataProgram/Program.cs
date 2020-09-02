using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
     public class InsertDataProgram
    {
        public static void Main(string[] args)
        {
            new InsertDataProgram().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=DESKTOP-1ID32BM\\SQLEXPRESS; database=Student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student  (id, name, email, join_date)values('101', 'Ronald Trump', 'ronald@example.com', '1/12/2017')", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}