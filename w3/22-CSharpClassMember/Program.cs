using System;
/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 27 - 01 - 2021
Pembelajaran : OOP
*/
namespace _22_CSharpClassMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "Red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }
}
