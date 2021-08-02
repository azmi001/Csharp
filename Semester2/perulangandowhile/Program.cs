using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Nama 	: Azmi Munif Hartono
NIM 	: 20210012
Kelas 	: Gametech 2B
Tugas	: C# Latihan perulangan do while
Tanggal : 09 - 16 - 2021
*/
namespace perulangandowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Belajar Perulangan do While");
            int ulang = 1;
            do
            {
                Console.WriteLine("Ulang Sampai : " + ulang);
                ulang++;
            } while (ulang <= 10);
            Console.Read();
        }
    }
}
