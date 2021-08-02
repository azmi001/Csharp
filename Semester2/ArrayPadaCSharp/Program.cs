using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Nama 	: Azmi Munif Hartono
NIM 	: 20210012
Kelas 	: Gametech 2B
Tugas	: C# Latihan Array Pada C#
Tanggal : 09 - 16 - 2021
*/
namespace ArrayPadaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ini adalah Contoh Array 1 Dimensi
            int[] array = new int[] {1,2,3};//Ini adalah Contoh Array
            Console.WriteLine("\t\t Belajar Bikin Array");//Ini Akan Dicetak
            Console.WriteLine("\n\n===========Array 1 Dimensi Menggunakan C#===========");
            for (int i = 0; i < array.Length; i++)//Membuat Perulangan
            {
                Console.WriteLine("Array Satu Dimensi" + (i + 1)+" : " + array[i]);
            }
            //Ini adalah Array 2 Dimensi
            Console.WriteLine("\n\n\n========Array 2 Dimensi Menggunakan C#========");
            int baris_array = 2;
            int klm_array = 2;
            int[,] matrik_array = new int[baris_array, klm_array];
            int x = 1;
            for (int s = 0; s < baris_array; s++)
            {
                for (int j = 0; j < klm_array; j++)
                {
                    matrik_array[s,j] = x;
                    x++;
                }
            }
            for (int s = 0; s < baris_array; s++)
            {
                for (int j = 0; j < klm_array; j++)
                {
                    Console.Write("Array 2 Dimensi" + matrik_array[s,j] + "\t");//array yang akan dicetak
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
