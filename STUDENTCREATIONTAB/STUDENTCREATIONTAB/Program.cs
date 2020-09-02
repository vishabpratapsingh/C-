using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
   public  class TableProgram
    {
         public static void Main(string[] args)
        {
            new TableProgram().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=DESKTOP-1ID32BM\\SQLEXPRESS; database=Student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table student(id int not null,    name varchar(100), email varchar(50), join_date date)", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
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