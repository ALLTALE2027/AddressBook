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


            //UC -2-3-4
            //AddressBook person = new AddressBook();

            //Console.WriteLine("enter details of  contact to add in address book");
            //Console.WriteLine("first name: ");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("last name: ");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Address: ");
            //string address = Console.ReadLine();
            //Console.WriteLine("City: ");
            //string city = Console.ReadLine();
            //Console.WriteLine("State: ");
            //string state = Console.ReadLine();
            //Console.WriteLine("Area zipcode: ");
            //int zipcode = int.Parse(Console.ReadLine());
            //Console.WriteLine("Mobile Number: ");
            //long mobile_no = long.Parse(Console.ReadLine());
            //Console.WriteLine("Email address: ");
            //string email = Console.ReadLine();
            //person.AddContact(firstName, lastName, address, city, state, zipcode, mobile_no, email);

            //Console.WriteLine();
            //person.GetContact();


            //Console.WriteLine("Select what you want to do in Address Book: ");
            //Console.WriteLine("1.Update contact details");
            //Console.WriteLine("2.Delete contact from Book");
            //int selection = int.Parse(Console.ReadLine());

            //switch (selection)
            //{
            //    case 1:
            //        Console.WriteLine();
            //        person.UpdateContact();
            //        Console.WriteLine();
            //        break;
            //    case 2:
            //        Console.WriteLine();
            //        person.DeleteContact();
            //        break;
            //    default:
            //        Console.WriteLine("Select the action from given choices only");
            //        break;
            //}


            //UC-5
            bool continue_loop = true;
            MultipleAddressBook person = new MultipleAddressBook();
            Console.WriteLine("Previous Contact Details: ");
            person.GetContact();

            while (continue_loop)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("Select what you want to do with the Address Book: ");
                Console.WriteLine("1.Add contact");
                Console.WriteLine("2.Display contact by name");
                Console.WriteLine("3.Update contact details");
                Console.WriteLine("4.Delete contact from Book");
                Console.WriteLine("5.Display all contacts");
                Console.WriteLine("6.Check for person by city or state name");
                Console.WriteLine("7.View person by city or state name");
                Console.WriteLine("8.View persons count living in same city or state");
                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
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
                        person.JSONserialisation();
                        break;

                    case 2:
                        Console.WriteLine("Enter the first name of contact to see details");
                        firstName = Console.ReadLine();
                        person.GetContact(firstName);
                        break;
                    case 3:
                        Console.WriteLine("Enter the first name of contact to update");
                        firstName = Console.ReadLine();
                        person.UpdateContact(firstName);
                        person.JSONserialisation();
                        break;
                    case 4:
                        Console.WriteLine("Enter the first name of contact you want to delete");
                        firstName = Console.ReadLine();
                        person.RemoveContact(firstName);
                        person.JSONserialisation();
                        break;
                    case 5:person.GetContact();
                        break;
                    case 6:person.CheckPersonByCityOrStateName();
                        break;
                    case 7:person.DisplayByCityOrStateName();
                        break;
                    case 8:person.DisplayPersonsCountByCityStateName();
                        break;
                    default:
                        Console.WriteLine("Select the action from given choices only");
                        break;
                }

                Console.WriteLine("Do you want to continue with address book (y/n):");
                char ans = Convert.ToChar(Console.ReadLine());

                continue_loop = ans == 'y';
            }



        }
    }
}