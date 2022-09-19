using System;
using System.Reflection;

namespace lb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Adam", "Adamson");
            Console.WriteLine($"{employee._name} {employee._surname} {employee._experience} {employee.Role} {employee.Handouts} {employee.Salary}");
            Console.ReadLine();
            Console.WriteLine(employee.Koood);


        }
    }
}