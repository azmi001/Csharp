using System;

namespace _15_CSharpBreakCountinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            for (int j = 0; j < 10; j++)
            {
                if (j == 4)
                {
                    continue;
                }
                Console.WriteLine(j);
            }
            Console.WriteLine("\n");
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine(a);
                a++;
                if (a == 4)
                {
                    break;
                }
            }
            Console.WriteLine("\n");
            int b = 0;
            while (b < 10)
            {
                if (b == 4)
                {
                    b++;
                    continue;
                }
                Console.WriteLine(b);
                b++;
            } 
        }
    }
}
