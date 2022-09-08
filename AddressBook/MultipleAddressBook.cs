using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class MultipleAddressBook
    {
        Dictionary<string, Contact> contactsDirectory;

        public MultipleAddressBook()
        {
            this.contactsDirectory = new Dictionary<string, Contact>();

        }

        public void AddContact(string firstName, string lastName, string address, string city, string state,
            int zipCode,
            long mobileNumber, string email)
        {
            //if (this.contactsDirectory.ContainsKey(firstName))
            //    Console.WriteLine("Contact with this name is already in Address Book");

            //UC7
            if (contactsDirectory.Any(x => x.Key == firstName))
                Console.WriteLine("Contact is already present");


            else
            {
                Contact contacts = new Contact(firstName, lastName, address, city, state, zipCode, mobileNumber, email);
                this.contactsDirectory.Add(firstName, contacts);
                Console.WriteLine("Contact added in address book");
            }


        }

        public void GetContact(string name)
        {
            if (this.contactsDirectory.ContainsKey(name))
            {
                Console.WriteLine("Persons contact details are:");
                Console.WriteLine(
                    $"Full Name : {this.contactsDirectory[name].firstName}  {this.contactsDirectory[name].lastName}");
                Console.WriteLine(
                    $"Lives in {this.contactsDirectory[name].city} city and address is {this.contactsDirectory[name].address},pincode-{this.contactsDirectory[name].zipCode}");
                Console.WriteLine(
                    $"Contact using mobile no-{this.contactsDirectory[name].mobileNumber} and email is {this.contactsDirectory[name].email}");
            }

            else
            {
                Console.WriteLine("Contact with this name is not in Address Book");
            }
        }

        public void GetContact()
        {
            foreach (var contacts in this.contactsDirectory.Values)
            {
                Console.WriteLine("Persons contact details are:");
                Console.WriteLine(
                    $"Full Name : {contacts.firstName}  {contacts.lastName}");
                Console.WriteLine(
                    $"Lives in {contacts.city} city and address is {contacts.address},pincode-{contacts.zipCode}");
                Console.WriteLine(
                    $"Contact using mobile no-{contacts.mobileNumber} and email is {contacts.email}");
                Console.WriteLine("-------------------------PhoneBook-----------------------------------");
            }
        }

        public void UpdateContact(string name)
        {

            bool update = true;

            while (update)
            {
                Console.WriteLine("what do you want to update");
                Console.WriteLine("1.last name: ");
                Console.WriteLine("2.Address: ");
                Console.WriteLine("3.City: ");
                Console.WriteLine("4.State: ");
                Console.WriteLine("5.Area zipcode: ");
                Console.WriteLine("6.Mobile Number: ");
                Console.WriteLine("7.Email address: ");
                int updateChoice = int.Parse(Console.ReadLine());

                switch (updateChoice)
                {
                    case 1:
                        string lastName = Console.ReadLine();
                        this.contactsDirectory[name].lastName = lastName;
                        break;
                    case 2:
                        string address = Console.ReadLine();
                        this.contactsDirectory[name].address = address;
                        break;
                    case 3:
                        string city = Console.ReadLine();
                        this.contactsDirectory[name].city = city;
                        break;
                    case 4:
                        string state = Console.ReadLine();
                        this.contactsDirectory[name].state = state;
                        break;
                    case 5:
                        int zipcode = int.Parse(Console.ReadLine());
                        this.contactsDirectory[name].zipCode = zipcode;
                        break;
                    case 6:
                        long mobile_no = long.Parse(Console.ReadLine());
                        this.contactsDirectory[name].mobileNumber = mobile_no;
                        break;
                    case 7:
                        string email = Console.ReadLine();
                        this.contactsDirectory[name].email = email;
                        break;
                    default:
                        Console.WriteLine("Select the correct choice");
                        break;
                }

                Console.WriteLine("Do you want to update more details(y/n):");
                char ans = Convert.ToChar(Console.ReadLine());

                if (ans == 'y')
                    update = true;
                else
                    update = false;
            }

            Console.WriteLine("Contact updated in address book");
        }

        public void RemoveContact(string name)
        {
            if (this.contactsDirectory.ContainsKey(name))
            {
                this.contactsDirectory.Remove(name);
                Console.WriteLine("Contact removed in address book");
            }
            else
                Console.WriteLine("Contact is not in address book check the  entered first name again");
        }

        public void CheckPersonByCityOrStateName()
        {
            Console.WriteLine("Enter City or State Name");
            string check = Console.ReadLine();
            if (contactsDirectory.Any(x => x.Value.city == check || x.Value.state == check))
                Console.WriteLine("Contact is present");
            else
                Console.WriteLine("Contact is not present");
        }

        public void DisplayByCityOrStateName()
        {
            Console.WriteLine("Enter City or State Name");
            string check = Console.ReadLine();
            if (contactsDirectory.Any(x => (x.Value.city == check) || (x.Value.state == check)))
            {
                foreach (KeyValuePair<string, Contact> Dict in contactsDirectory)
                {

                    if (Dict.Value.state == check || Dict.Value.city == check)
                    {
                        Console.WriteLine("{0} Lives in {1}", Dict.Key, check);
                    }

                }
            }
            else
                Console.WriteLine("No one Lives in {0}", check);
        }

        public void DisplayPersonsCountByCityStateName()
        {
            Console.WriteLine("Enter City or State Name");
            string check = Console.ReadLine();
            int count = 0;
            if (contactsDirectory.Any(x => (x.Value.city == check) || (x.Value.state == check)))
            {
                foreach (KeyValuePair<string, Contact> Dict in contactsDirectory)
                {
                    if (Dict.Value.state == check || Dict.Value.city == check)
                        count++;
                }
                Console.WriteLine("{0} person(s) Lives in {1}", count, check);
            }
            else Console.WriteLine("No one Lives in {0}", check);

        }
    }
}


