using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Nama 	: Azmi Munif Hartono
NIM 	: 20210012
Kelas 	: Gametech 2B
Tugas	: C# Latihan Kondisi Swicth
Tanggal : 09 - 16 - 2021
*/
namespace kondisiswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string pilihan;
            Console.WriteLine("1 Untuk Teh \n 2 Untuk Soda");
            Console.Write("Masukan Pilihan :");
            pilihan = Console.ReadLine();
            switch (pilihan)
            {
                case"1":
                    Console.WriteLine("Anda Memilih Teh");
                    break;
                    default:
                    Console.Write("Anda Memilih Soda");
                    break;
            }
            Console.Read();
        }
    }
}
