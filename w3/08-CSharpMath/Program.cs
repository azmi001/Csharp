using System;

namespace _08_CSharpMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            float z = -4.7f;
            float a = 9.99f;
            int b = 64;

            Console.WriteLine(Math.Max(x,y));// Mencari Max
            Console.WriteLine(Math.Min(x,y));// Mencari min
            Console.WriteLine(Math.Sqrt(b));// Pangkat 2 dari
            Console.WriteLine(Math.Abs(z));// Mengubah jadi bilangan positif
            Console.WriteLine(Math.Round(a));// Membulatkan bilangan
        }
    }
}