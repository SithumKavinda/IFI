using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Vidly.DAO
{
    public class DBConnection
    {
        

        public SqlConnection GetConnection()
        {
            string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=vidly;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con=null;

            try
            {
                con = new SqlConnection(connection_string);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return con;
        }
    }
}