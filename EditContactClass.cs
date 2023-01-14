using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSql
{
    public class EditContactClass
    {
        public static void EditContact(string UpdateThis, string value, string Name)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=I-CHANGE-THE-NA\SQLEXPRESS;Initial catalog=AddressBook;Integrated Security=true");
                connection.Open();
                if (UpdateThis != "PhoneNumber" || UpdateThis != "Zip")
                {
                    SqlCommand cmd = new SqlCommand($"update Address_Book set {UpdateThis} = '{value}' where FirstName = '{Name}';", connection);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand($"update Address_Book set {UpdateThis} = {value} where FirstName = '{Name}';", connection);
                    cmd.ExecuteNonQuery();
                }
                
                Console.WriteLine("Data Edited");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
