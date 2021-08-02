using System;

namespace _11_CSharpIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 18;
            if (5 > 3)
            {
                Console.WriteLine("5 Lebih besar dari angka 3");
            }
            if (a > b)
            {
                Console.WriteLine("a lebih besar daripada variable b");
            }

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good Day");
            } else
            {
                Console.WriteLine("Good Evening");
            }

            int x = 10;
            int y = 20;
            int z = 30;
            if (y < x)
            {
                Console.WriteLine("y lebih kecil dari x");
            } else if (y < z)
            {
                Console.WriteLine("y lebih kecil dari z");
            } else 
            {
                Console.WriteLine("y lebih besar dari variable z");
            }

            // else if versi singkat
            int time2 = 20;
            string result = (time2 < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}
