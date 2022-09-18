using System;
using System.Reflection;

namespace lb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Apartment = "132";
            address.Street = "H";
            address.House = "43";
            address.City = "Kyiv";
            address.Country = "Ukraine";
            address.Index = 1;

            foreach (PropertyInfo property in address.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(address, null));
            }

            Console.ReadLine();
        }
    }
}