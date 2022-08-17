namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            //UC-1
            //AddressBook contact=new AddressBook();
            //contact.AddContact("darshan","deshmukh","abcd chowk","XYZ","Abcedefg",123456,9123456780,"hello@gmail.com");
            //contact.GetContact();


            //UC2
            AddressBook person = new AddressBook();

            Console.WriteLine("enter details of  contact to add in address book");
            Console.WriteLine("first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine("State: ");
            string state = Console.ReadLine();
            Console.WriteLine("Area zipcode: ");
            int zipcode = int.Parse(Console.ReadLine());
            Console.WriteLine("Mobile Number: ");
            long mobile_no = long.Parse(Console.ReadLine());
            Console.WriteLine("Email address: ");
            string email = Console.ReadLine();
            person.AddContact(firstName, lastName, address, city, state, zipcode, mobile_no, email);

            Console.WriteLine();
            person.GetContact();
        }
    }
}