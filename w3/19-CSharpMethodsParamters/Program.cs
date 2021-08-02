using System;
/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 27 January 2021
Penggunaan Program : Belajar C#
*/
namespace _19_CSharpMethodsParamters
{
    class Program
    {
        static void MethodGw(string fname, int age)
        {
            Console.WriteLine(fname + " Refsnes" + " is " + age);
        }

        static void Negara(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static int MethodPertambahan(int x)
        {
            return 5 + x;
        }

        static int MethodPertambahan2(int x,int y)
        {
            return x + y;
        }

        static void AnakTermuda(string anak1, string anak2, string anak3)
        {
            Console.WriteLine("Anak termuda adalah : " + anak3);
        }

        static void AnakTermuda2(string child1 = "Azmi", string child2 = "Agus", string child3 = "Udin")
        {
            Console.WriteLine(child3);
        }

        static void Main(string[] args)
        {
            MethodGw("Liam", 5);
            MethodGw("Jenny", 8);
            MethodGw("Anja", 31);

            Negara("Sweden");
            Negara("India");
            Negara();
            Negara("USA");

            int z = MethodPertambahan2(8, 9);

            Console.WriteLine(MethodPertambahan(3));

            Console.WriteLine(MethodPertambahan2(5, 3));

            Console.WriteLine(z);

            AnakTermuda(anak1: "John", anak2: "Liam", anak3: "Ucup");

            AnakTermuda2("anak3");
        }
    }
}
