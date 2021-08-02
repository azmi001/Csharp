using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Nama 	: Azmi Munif Hartono
NIM 	: 20210012
Kelas 	: Gametech 2B
Tugas	: C# Latihan Perulangan For Each
Tanggal : 09 - 16 - 2021
*/
namespace Perulanganforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nama = {"Caniago","Nuraini","Dea","Siti"};
            Console.WriteLine("Perulangan For Each");
            Console.WriteLine("-------------------");
            foreach(String urutan in nama)
            {
                Console.WriteLine(" " + urutan);
            }
            Console.Read();
        }
    }
}
