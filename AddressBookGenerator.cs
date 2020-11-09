using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUsingLinq
{
    public class AddressBookGenerator
    {
        public  List<AddressBookModel> addressBook = new List<AddressBookModel>();

        public AddressBookGenerator()
        {
            addressBook.Add(new AddressBookModel { firstName = "Akash", secondName = "Singh", address = "40/720", city = "Waidhan", state = "MP", zip = 486886, phoneNumber = 9407357961, email = "akash@gmail.com", contactType = "Family", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Ashutosh", secondName = "Sameer", address = "40/721", city = "Waidhan", state = "MP", zip = 486886, phoneNumber = 9407357962, email = "ahutosh@gmail.com", contactType = "Friends", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Amit", secondName = "Saha", address = "40/722", city = "Waidhan", state = "MP", zip = 486886, phoneNumber = 9407357963, email = "amit@gmail.com", contactType = "Friends", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Namrata", secondName = "Yadav", address = "40/723", city = "Waidhan", state = "MP", zip = 486886, phoneNumber = 9407357964, email = "namrata@gmail.com", contactType = "Family", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Sukanya", secondName = "Singh", address = "40/724", city = "Vindhyanagar", state = "UP", zip = 486885, phoneNumber = 9407357965, email = "sukanya@gmail.com", contactType = "Professional", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Monu", secondName = "Vivek", address = "40/725", city = "Vindhyanagar", state = "UP", zip = 486885, phoneNumber = 9407357966, email = "monu@gmail.com", contactType = "Family", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Eshan", secondName = "Mishra", address = "40/726", city = "Vindhyanagar", state = "UP", zip = 486885, phoneNumber = 9407357967, email = "eshan@gmail.com", contactType = "Professional", addressBookName = "Personal" });
            addressBook.Add(new AddressBookModel { firstName = "Naveen", secondName = "Gupta", address = "40/727", city = "Vindhyanagar", state = "UP", zip = 486885, phoneNumber = 9407357968, email = "naveen@gmail.com", contactType = "Professional", addressBookName = "Personal" });
        }
    }
}
