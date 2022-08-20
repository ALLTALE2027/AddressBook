using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public long mobileNumber;
        public string email;

        public Contact(string firstName, string lastName, string address, string city, string state, int zipCode,
            long mobileNumber, string email)
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
    }
}
