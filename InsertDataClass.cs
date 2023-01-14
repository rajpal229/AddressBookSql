using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSql
{
    public class InsertDataClass
    {
        public static void InsertData(string FirstName, string LastName, string Address, string City, string State, int Zip, long PhoneNumber, string Email) 
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=I-CHANGE-THE-NA\SQLEXPRESS;Initial catalog=AddressBook;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand($"insert into Address_Book values('{FirstName}','{LastName}','{Address}','{City}','{State}','{Zip}','{PhoneNumber}','{Email}')", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data Inserted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
