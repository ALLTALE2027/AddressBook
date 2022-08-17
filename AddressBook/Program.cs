namespace AddressBook
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            //UC-1
            AddressBook contact=new AddressBook();
            contact.AddContact("darshan","deshmukh","abcd chowk","XYZ","Abcedefg",123456,9123456780,"hello@gmail.com");
            contact.GetContact();
        }
    }
}