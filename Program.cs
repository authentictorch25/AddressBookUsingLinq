using System;

namespace AddressBookUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address Book");
            AddressBookGenerator gen = new AddressBookGenerator();
            foreach(var v in gen.addressBook)
            {
                Console.WriteLine(v.firstName +" "+ v.address +" "+ v.phoneNumber);
            }
        }
    }
}
