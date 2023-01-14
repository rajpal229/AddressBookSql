﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSql
{
    public class InsertTableClass
    {
        public static void InsertTable()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=I-CHANGE-THE-NA\SQLEXPRESS;Initial catalog=AddressBook;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create Table Address_Book(Id int primary key identity(1,1),FirstName varchar(200),LastName varchar(200),Address varchar(200),City varchar(200),State varchar(200),Zip int,PhoneNumber bigint,Email varchar(200))", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
