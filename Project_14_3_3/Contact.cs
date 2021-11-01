using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_14_3_3
{
    internal class Contact
    {
        public Contact(string name, string lastName, long phoneNumber, string email)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public long PhoneNumber { get; private set; }
        public string Email { get; private set; }
    }
}
