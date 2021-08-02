using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Nama 	: Azmi Munif Hartono
NIM 	: 20210012
Kelas 	: Gametech 2B
Tugas	: C# Latihan Kondisi If Else
Tanggal : 09 - 16 - 2021
*/
namespace kondisiifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            string harga;
            Console.Write("Masukkan Harga Barang :\t");
            harga = Console.ReadLine();
            int hargabuku = Convert.ToInt32(harga);
            if (hargabuku<35000)
            {
                Console.Write("Saya Beli Deh");
            } 
            else 
            {
                Console.Write("harganya mahal");
            }
            Console.Read();
        }
    }
}
