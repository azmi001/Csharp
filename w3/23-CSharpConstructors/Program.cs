using System;
/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 27 - 01 - 2021
Pembelajaran : OOP
*/
namespace _23_CSharpConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Car Opel = new Car("Astra", "White", 2005);

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }
}
