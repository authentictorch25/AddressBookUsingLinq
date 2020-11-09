using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUsingLinq
{
    public class AddressBookModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public long zip { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; set; }
        public string contactType { get; set; }
        public string addressBookName { get; set; }
    }
}
