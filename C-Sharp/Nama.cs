using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name: ");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter Your last name ");
            String lastName = Console.ReadLine();

            String fullName = firstName + " " + lastName;
            String userName = fullName.Insert(0, "Mr. ");

            Console.WriteLine("Selamat Datang " + userName);
            Console.ReadKey();
        }
    }
}
