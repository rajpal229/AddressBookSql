using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSql
{
    public class AlterClass
    {
        public static void Alter(string columnName, string dataType)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=I-CHANGE-THE-NA\SQLEXPRESS;Initial catalog=AddressBook;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand($"alter table Address_Book add {columnName} {dataType}", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Column Added");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
