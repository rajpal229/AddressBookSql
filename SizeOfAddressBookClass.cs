using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSql
{
    public class SizeOfAddressBookClass
    {
        public static void Size(string find, string value)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=I-CHANGE-THE-NA\SQLEXPRESS;Initial catalog=AddressBook;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand($"select count(Id) from Address_Book where {find}='{value}' group by {find}", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int size = (int)reader[0];
                    Console.WriteLine("The size of the address book is: " + size);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
