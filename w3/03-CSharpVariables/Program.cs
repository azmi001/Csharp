using System;

namespace CSharpVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int _nomorKu = 10;
            double nomorDoubleKu = 69.69;
            char hurufKu = 'A';
            bool booleanKu = true;
            string textKu = "Hallo";

            int x = 5, y = 10, z = 50;

            Console.WriteLine("\nNomor ku adalah " + _nomorKu);
            Console.WriteLine("Nomor double ku adalah " + nomorDoubleKu);
            Console.WriteLine("Huruf ku adalah " + hurufKu);
            Console.WriteLine("Bolean ku adalah " + booleanKu);
            Console.WriteLine("Tesk ku adalah " + textKu + "\n");

            Console.WriteLine(x + y + z +"\n"); // menampilkan hasil x + y
        }
    }
}