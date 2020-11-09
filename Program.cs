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
            /// UC6
            gen.GetCountByCityOrState();
            ///UC7
            gen.SortedDetailsByNameGivenCity();
            ///UC8
            gen.ContactbyType();
        }
    }
}
