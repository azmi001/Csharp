using System;
using System.Linq;

/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 23 January 2021
Penggunaan Program : Belajar C#
*/

namespace _16_CSharpArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] angkaSaya = {5, 1, 8, 9};
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length+"\n\n");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine("\n\n");
            Array.Sort(cars);
            foreach (string i in cars){
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\n");

            Array.Sort(angkaSaya);
            foreach (int i in angkaSaya){
                Console.WriteLine(i);
            }

            // min, max, sum untuk array harus diperlukan System.Linq;
            Console.WriteLine(angkaSaya.Max()); //Mencari Nilai Max
            Console.WriteLine(angkaSaya.Min()); //Mencari nilai Min
            Console.WriteLine(angkaSaya.Sum()); //Mnecari Jumlah Nilai
        }
    }
}
