using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.DAO
{
    internal class DBConnection
    {
        string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=vidly;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        /*This class returns a Database connection*/

        /*
        public static Connection GetConnection()
        {
            return Connection;
        }
        */
    }
}