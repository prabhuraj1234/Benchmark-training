using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ado1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection ();
                con.ConnectionString = "Server=.;database=practice;trusted_connection=true";
                con.Open();
                Console.WriteLine("connection_opened");

                SqlCommand cmd = new SqlCommand("select * from employee",con);


                cmd.CommandType = CommandType.Text;

              

                SqlDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {
                 Console.WriteLine(reader[0] + "\t" + reader[1] + "\t\t" + reader[2] + "\t\t" + reader[3] + "\t" + reader[4] );
                }


                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        
    }
}
