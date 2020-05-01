using System;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection con = new SqlConnection(DBContext.connectString);
            //con.Open();
            //con.Close();
            using (DBContext dbContext = new DBContext())
            {
                Console.WriteLine(dbContext.Users.Count());
            }

            Console.WriteLine("Done");
        }
    }
}
