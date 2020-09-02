using System;
using System.Data.SqlClient;
using System.Data;


     public class DATASETPROGRAM
    {
        static void Main(string[] args)
        {
            new DATASETPROGRAM().Connecting();
        }
        public void Connecting()
        {
        using (
                 // Creating Connection  
                 SqlConnection con = new SqlConnection("data source=DESKTOP-1ID32BM\\SQLEXPRESS; database=Student; integrated security=SSPI")
             )
        {
            con.Open();
       
            SqlDataAdapter sde = new SqlDataAdapter("Select * from student", con);
            DataSet ds = new DataSet();
            sde.Fill(ds);


        }
        }
    }
