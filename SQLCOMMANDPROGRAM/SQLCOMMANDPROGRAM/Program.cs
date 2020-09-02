using System;
using System.Data.SqlClient;
public class A
{
    public static void Main(string[] args)
    {
        new A().CreateTable();
    }


    public void CreateTable()
    {
        using (SqlConnection con = new SqlConnection("data source=DESKTOP-1ID32BM\\SQLEXPRESS; Database= Student;integrated security=SSPI")
            )
        {




            SqlCommand cm = new SqlCommand("select * from Student", con);
  
            con.Open();


            SqlDataReader sdr = cm.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine(sdr["name"] + " " + sdr["email"]);
            }
        }
    }
}

