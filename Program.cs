namespace AddressBookSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Option\n1.Create Table\n2.Insert Data Into Table");
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
                }
                break;
            }
        }
    }
}