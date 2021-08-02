using System;

namespace _14_CSharpForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int j = 0; j <= 10; j = j + 2)
            {
                Console.WriteLine(j);
            }

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
