using System;

namespace AddressBookUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookGenerator gen = new AddressBookGenerator();
            /// UC3 
            gen.UpdateContactUsingName();
            /// UC4 
            gen.DeleteContact();
            /// UC5 
            gen.GetContactUsingCityOrStateName();
        }
    }
}
