using System;

namespace _07_CSharpOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100 + 50;
            int sum1 = 100 + 50 + x;
            int sum2 = sum1 + 250;
            int sum3 = sum2 + sum2;
            Console.WriteLine("Hasil sum 3 : " + sum3);

            int y = 10;
            y += 5;
            Console.WriteLine("Hasil dari y adalah : " + y);

            int a = 20;
            a -= 3;
            Console.WriteLine("Hasil dari a adalah : " + a);

            int b = 40;
            b *= 3;
            Console.WriteLine("Hasil dari b adalah : " + b);

            int c = 30;
            c /= 3;
            Console.WriteLine("Hasil dari c adalah : " + c);

            int d = 10;
            d %= 3;// artinya yang bisa habis dibagi jika bisa habis dibagi maka hasilnya 0 jika ada sisa ex disini ada 10, 3 x 3 = 9 , 9 - 10 = 1 sisanya maka yang menjadi ouputnya
            Console.WriteLine("Hasil dari d adalah : " + d);

            int e = 5;
            e |= 3;
            Console.WriteLine("Hasil dari e adalah : " + e);

            int f = 5;
            f ^= 3;
            Console.WriteLine("Hasil dari f adalah : " + f);

            int g = 5;
            g >>= 3;
            Console.WriteLine("Hasil dari g adalah : " + g);

            int h = 5;
            h <<= 3;
            Console.WriteLine("Hasil dari h adalah : " + h);

            int i = 5;
            int j = 3;
            int l = 10;

            Console.WriteLine("\n");
            Console.WriteLine(i == j);
            Console.WriteLine(i != j);
            Console.WriteLine(i > j);
            Console.WriteLine(i < j);
            Console.WriteLine(i >= j);
            Console.WriteLine(i <= j);
            Console.WriteLine("\n");

            Console.WriteLine(l > 5 && l < 15);
            Console.WriteLine(l > 5 || l < 15);
            Console.WriteLine(!(l > 5 && l < 15));
            Console.WriteLine("\n");
        }
    }
}