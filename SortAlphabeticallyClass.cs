using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSql
{
    public class SortAlphabeticallyClass
    {
        public static void sort(string column)
        {
            {
                try
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=I-CHANGE-THE-NA\SQLEXPRESS;Initial catalog=AddressBook;Integrated Security=true");
                    connection.Open();
                    SqlCommand cmd = new SqlCommand($"select * from Address_Book order by {column}", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int Id = (int)reader["Id"];
                        string FirstName = (string)reader["FirstName"];
                        string LastName = (string)reader["LastName"];
                        string Address = (string)reader["Address"];
                        string City = (string)reader["City"];
                        string State = (string)reader["State"];
                        int Zip = (int)reader["Zip"];
                        long PhoneNumber = (long)reader["PhoneNumber"];
                        string Email = (string)reader["Email"];
                        Console.WriteLine(Id + " " + FirstName + " " + LastName + " " + Address + " " + City + " " + State + " " + Zip + " " + PhoneNumber + " " + Email);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
