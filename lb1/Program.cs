using System;
using System.Reflection;

namespace lb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Apartment = "ds";
            address.Street = "ds";
            address.House = "ds";
            address.City = "ds";
            address.Country = "ds";
            address.Index = 1;

            foreach (PropertyInfo property in address.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(address, null));
            }

            Console.ReadLine();
        }
    }
}