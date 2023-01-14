using System.Drawing;

namespace AddressBookSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Option\n1.Create Table\n2.Insert Data Into Table\n3.Edit Contact (using name)\n4.Delete Data(using Name)\n5.Retrieve Data(using City or State)\n6.Size of Address Book by State or City");
            int op = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (op)
                {
                    case 1:
                        InsertTableClass.InsertTable();
                        break;
                    case 2:
                        Console.WriteLine("Enter FirstName");
                        string FirstName = Console.ReadLine();
                        Console.WriteLine("Enter LastName");
                        string LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        string Address = Console.ReadLine();
                        Console.WriteLine("Enter City");
                        string City = Console.ReadLine();
                        Console.WriteLine("Enter State");
                        string State = Console.ReadLine();
                        Console.WriteLine("Enter Zip");
                        int Zip = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter PhoneNumber");
                        long PhoneNumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter Email");
                        string Email = Console.ReadLine();
                        InsertDataClass.InsertData(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
                        break;
                    case 3:
                        Console.WriteLine("Enter the first name");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter Type of Value to Update(Using Name)\n1.Address\n2.City\n3.State\n4.Zip\n5.PhoneNumber\n6.Email");
                        int op1 = Convert.ToInt32(Console.ReadLine());
                        while (true)
                        {
                            switch (op1)
                            {
                                case 1:
                                    Console.WriteLine("Enter the Address");
                                    string UpAddress = Console.ReadLine();
                                    EditContactClass.EditContact("Address", UpAddress, Name);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the City");
                                    string UpCity = Console.ReadLine();
                                    EditContactClass.EditContact("City", UpCity, Name);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the State");
                                    string UpState = Console.ReadLine();
                                    EditContactClass.EditContact("State", UpState, Name);
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the Zip");
                                    string UpZip = Console.ReadLine();
                                    EditContactClass.EditContact("Zip", UpZip, Name);
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the PhoneNumber");
                                    string UpPhone = Console.ReadLine();
                                    EditContactClass.EditContact("PhoneNumber", UpPhone, Name);
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the Email");
                                    string UpEmail = Console.ReadLine();
                                    EditContactClass.EditContact("Email", UpEmail, Name);
                                    break;
                            }
                            break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Name");
                        string DeleteName = Console.ReadLine();
                        DeleteDataClass.deleteData(DeleteName);
                        break;
                    case 5:
                        Console.WriteLine("Enter Column for Data to be Retrieved");
                        string RetrieveColumn = Console.ReadLine();
                        Console.WriteLine("Enter value in Column");
                        string RetrieveValue = Console.ReadLine();
                        RetrieveDataClass.RetrieveData(RetrieveColumn, RetrieveValue);
                        break;
                    case 6:
                        Console.WriteLine("Enter Column Name");
                        string RetrieveColumn1 = Console.ReadLine();
                        Console.WriteLine("Enter value in Column");
                        string RetrieveValue2 = Console.ReadLine();
                        SizeOfAddressBookClass.Size(RetrieveColumn1, RetrieveValue2);
                        break;
                }
            break;
            }
        }
    }
}