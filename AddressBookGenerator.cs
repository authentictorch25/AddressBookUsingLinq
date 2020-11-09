using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookUsingLinq
{
    public class AddressBookGenerator
    {
        public List<AddressBookModel> addressBook = new List<AddressBookModel>();
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookGenerator"/> class.
        /// </summary>
        public AddressBookGenerator()
        {
            addressBook.Add(new AddressBookModel { firstName = "Akash", lastName = "Singh", address = "40/720", city = "Waidhan", state = "MP", zip = 486886, phoneNumber = 9407357961, email = "akash@gmail.com", contactType = "Family", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Ashutosh", lastName = "Sameer", address = "40/721", city = "Waidhan", state = "MP", zip = 486886, phoneNumber = 9407357962, email = "ahutosh@gmail.com", contactType = "Friends", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Amit", lastName = "Saha", address = "40/722", city = "Waidhan", state = "MP", zip = 486886, phoneNumber = 9407357963, email = "amit@gmail.com", contactType = "Friends", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Namrata", lastName = "Yadav", address = "40/723", city = "Waidhan", state = "MP", zip = 486886, phoneNumber = 9407357964, email = "namrata@gmail.com", contactType = "Family", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Sukanya", lastName = "Singh", address = "40/724", city = "Vindhyanagar", state = "UP", zip = 486885, phoneNumber = 9407357965, email = "sukanya@gmail.com", contactType = "Professional", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Monu", lastName = "Vivek", address = "40/725", city = "Vindhyanagar", state = "UP", zip = 486885, phoneNumber = 9407357966, email = "monu@gmail.com", contactType = "Family", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Eshan", lastName = "Mishra", address = "40/726", city = "Vindhyanagar", state = "UP", zip = 486885, phoneNumber = 9407357967, email = "eshan@gmail.com", contactType = "Professional", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Naveen", lastName = "Gupta", address = "40/727", city = "Vindhyanagar", state = "UP", zip = 486885, phoneNumber = 9407357968, email = "naveen@gmail.com", contactType = "Professional", addressBookName = "Personal" });
        }
        /// <summary>
        /// Updates the name of the contact using.
        /// </summary>
        public void UpdateContactUsingName()
        {

            Console.WriteLine("Enter the First Name for contact you want to update :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Second Name for contact you want to update :");
            string lastName = Console.ReadLine();

            string address;
            string city;
            string state;
            long zip;
            long phoneNumber;
            string emailId;
            string contactType;
            string addressBookName;

            var contact = (from record in addressBook.AsEnumerable()
                           where record.firstName == firstName && record.lastName == lastName
                           select record).FirstOrDefault();
            Console.WriteLine("Enter option to update ");
            Console.WriteLine("1.Address");
            Console.WriteLine("2.City");
            Console.WriteLine("3.State");
            Console.WriteLine("4.Zip");
            Console.WriteLine("5.Phone Number");
            Console.WriteLine("6.email");
            Console.WriteLine("7.contact type");
            Console.WriteLine("8.address book name");
            int choice = Convert.ToInt32(Console.ReadLine());
            /// Matching the case to update the record
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the Address :");
                    address = Console.ReadLine();
                    contact.address = address;
                    break;
                case 2:
                    Console.WriteLine("Enter the City :");
                    city = Console.ReadLine();
                    contact.city = city;
                    break;
                case 3:
                    Console.WriteLine("Enter the State :");
                    state = Console.ReadLine();
                    contact.state = state;
                    break;
                case 4:
                    Console.WriteLine("Enter the Zip :");
                    zip = Convert.ToInt64(Console.ReadLine());
                    contact.zip = zip;
                    break;
                case 5:
                    Console.WriteLine("Enter the Phone Number :");
                    phoneNumber = Convert.ToInt64(Console.ReadLine());
                    contact.phoneNumber = phoneNumber;
                    break;
                case 6:
                    Console.WriteLine("Enter the email-id :");
                    emailId = Console.ReadLine();
                    contact.email = emailId;
                    break;
                case 7:
                    Console.WriteLine("Enter the contact type :");
                    contactType = Console.ReadLine();
                    contact.contactType = contactType;
                    break;
                case 8:
                    Console.WriteLine("Enter the address book name :");
                    addressBookName = Console.ReadLine();
                    contact.addressBookName = addressBookName;
                    break;
            }

            Console.WriteLine($"First Name:{contact.firstName}\nSecond Name:{contact.lastName}\n" +
                                    $"Address:{contact.address}, City:{contact.city}, State:{contact.state} PinCode: {contact.zip}\n" +
                                    $"Phone Number: {contact.phoneNumber}\nContact Type: {contact.contactType}\nAddress Book Name : {contact.addressBookName}");

        }
        /// <summary>
        /// Deletes the contact.
        /// </summary>
        public void DeleteContact()
        {
            Console.WriteLine("Enter the First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last Name");
            string lastName = Console.ReadLine();

            var contact = (from record in addressBook.AsEnumerable()
                           where record.firstName == firstName && record.lastName == lastName
                           select record).FirstOrDefault();
            addressBook.Remove(contact);
            foreach (var record in addressBook)
            {
                Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.lastName}\n" +
                                $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
            }
        }
        /// <summary>
        /// Gets the name of the contact using city or state.
        /// </summary>
        public void GetContactUsingCityOrStateName()
        {
            Console.WriteLine("Enter the choice");
            Console.WriteLine("C - City.");
            Console.WriteLine("S - State.");
            string choice = Console.ReadLine();
            Console.WriteLine("Enter the name of City or State by which you want the data -");
            string cityOrState = Console.ReadLine();
            if (choice == "C")
            {

                var contact = from record in addressBook.AsEnumerable()
                              where record.city == cityOrState
                              select record;

                foreach (var record in contact)
                {
                    Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.lastName}\n" +
                                    $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                    $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
                }
            }
            else
            {

                var contact = from record in addressBook.AsEnumerable()
                              where record.state == cityOrState
                              select record;
                foreach (var record in contact)
                {
                    Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.lastName}\n" +
                                    $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                    $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
                    Console.WriteLine("\n \n");
                }
            }
        }
        /// <summary>
        /// Gets the state of the count by city or.
        /// </summary>
        public void GetCountByCityOrState()
        {
            Console.WriteLine("CountByCity");

            var countbyCity = (from records in addressBook.AsEnumerable()
                               group records by records.city into Group
                               select new { City = Group.Key, NumberOfContacts = Group.Count() });

            foreach (var record in countbyCity)
            {
                Console.WriteLine($"City : {record.City}, Number Of Contacts : {record.NumberOfContacts}");
            }
            Console.WriteLine("CountByState");
            var countbyState = (from records in addressBook.AsEnumerable()
                                group records by records.state into Group
                                select new { State = Group.Key, NumberOfContacts = Group.Count() });
            foreach (var record in countbyState)
            {
                Console.WriteLine($"State : {record.State}, Number Of Contacts : {record.NumberOfContacts}");
            }
        }
        /// <summary>
        /// Sorteds the details alphabetically by name for a city.
        /// </summary>
        public void SortedDetailsByNameGivenCity()
        {
            Console.WriteLine("Enter the City ");
            string city = Console.ReadLine();
            var contact = (from record in addressBook.AsEnumerable()
                           orderby record.firstName
                           where (record.city == city)
                           select record);
            foreach (var record in contact)
            {
                Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.lastName}\n" +
                                $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
            }
        }
        public void ContactbyType()
        {
            Console.WriteLine("CountByType");

            var contactbyType = (from records in addressBook.AsEnumerable()
                                 group records by records.contactType into Group
                                 select new { ContactType = Group.Key, NumberOfContacts = Group.Count() });
            foreach (var record in contactbyType)
            {
                Console.WriteLine($"City : {record.ContactType}, Number Of Contacts : {record.NumberOfContacts}");
            }
        }
    }
}
