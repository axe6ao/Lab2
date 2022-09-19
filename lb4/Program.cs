using System;
using System.Reflection;

namespace lb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Surname = "Adamson";
            user.Name = "Adam";
            user.Login = "adam";
            user.Age = 27;

            foreach (PropertyInfo property in user.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(user, null));
            }

            Console.ReadLine();
        }
    }
}