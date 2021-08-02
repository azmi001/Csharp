using System;

namespace _06_CSharpUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username : ");
            string userName = Console.ReadLine();// membuat variable username untuk agar bisa ditulis oleh user menggunakan Console.Readline();
            Console.WriteLine("Username is : " + userName);

            /*
            Console.WriteLine("Enter your age:");
            int age = Console.ReadLine();
            Console.WriteLine("Your age is: " + age);

            kaya gini bakal munculin error message  karena string belom dikonversikan dulu ke int maka harus
            */

            Console.WriteLine("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is : " + age);
        }
    }
}