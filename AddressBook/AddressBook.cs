using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public long mobileNumber;
        public string email;

        public void AddContact(string firstName, string lastName, string address, string city, string state,
            int zipCode, long mobileNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.mobileNumber = mobileNumber;
            this.email = email;


        }

        public void GetContact()
        {

            Console.WriteLine("Persons contact details are:");
            Console.WriteLine(
                $"Full Name : {this.firstName}  {this.lastName}");
            Console.WriteLine(
                $"Lives in {this.city} city and address is {this.address},pincode-{this.zipCode}");
            Console.WriteLine(
                $"Contact using mobile no-{this.mobileNumber} and email is {this.email}");
            Console.WriteLine();

        }

        public void UpdateContact()
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
                        this.lastName = lastName;
                        break;
                    case 2:
                        string address = Console.ReadLine();
                        this.address = address;
                        break;
                    case 3:
                        string city = Console.ReadLine();
                        this.city = city;
                        break;
                    case 4:
                        string state = Console.ReadLine();
                        this.state = state;
                        break;
                    case 5:
                        int zipcode = int.Parse(Console.ReadLine());
                        this.zipCode = zipcode;
                        break;
                    case 6:
                        long mobile_no = long.Parse(Console.ReadLine());
                        this.mobileNumber = mobile_no;
                        break;
                    case 7:
                        string email = Console.ReadLine();
                        this.email = email;
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
            Console.WriteLine();
            GetContact();
        }
        public void DeleteContact()
        {
            this.firstName = null;
            this.lastName = null;
            this.address = null;
            this.city = null;
            this.state = null;
            this.zipCode = 0;
            this.mobileNumber = 0;
            this.email = null;

            Console.WriteLine("Contact deleted in Address Book");
            Console.WriteLine();

        }
    }
}
