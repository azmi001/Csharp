using System;

/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 23 January 2021
Penggunaan Program : Belajar C#
*/

namespace _17_CSharpArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an array
            string[] cars;

            // Add values, using new
            cars = new string[] {"Volvo", "BMW", "Ford"};

            // This would cause an error: cars = {"Volvo", "BMW", "Ford"};

            Console.WriteLine(cars[0]);
        }
    }
}
