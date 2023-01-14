namespace AddressBookSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Option\n1.Create Table (Address Book) ");
            int op = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (op)
                {
                    case 1:
                        InsertTableClass.InsertTable();
                        break;
                }
                break;
            }
        }
    }
}