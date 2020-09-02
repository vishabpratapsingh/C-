using System;
using System.Data.SqlClient;

public class A
{
    public static void Main(string[] args)
    {
        new A().Connecting();
    }
    public  void Connecting()
    {
        using(SqlConnection con= new SqlConnection("data source=DESKTOP-1ID32BM\\SQLEXPRESS;database=Student;integrated security=SSPI"))
        {
            con.Open();
            Console.WriteLine("connection is established succesfully");
        }
    }
} 
