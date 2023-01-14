using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AddressBookSql
{
    public class CreateDatabaseClass
    {
        public static void CreateDatabase()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=I-CHANGE-THE-NA\SQLEXPRESS;Initial catalog=master;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create database AddressBook", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Databass ctearted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
