using System;
namespace UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] angka = new int [10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int ttl = 0;
            int a = 0;
            while (a < 10)
            {
                if (angka[a] % 2 != 0)
                {
                    Console.Write(angka[a]+", ");
                    ttl = ttl + angka[a];
                }
                a++;
            }
            Console.Write("Total bilangan ganjil = " + ttl);
            System.Console.ReadKey();
        }
    }
}
