using System;
/*
Nama 	: Azmi Munif Hartono
NIM 	: 20210012
Kelas 	: Gametech 2B
Tugas	: C# Latihan perulangan while
Tanggal : 09 - 16 - 2021
*/
namespace perulanganwhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Belajar Perulangan While");
            int ulang = 1;
            while (ulang <= 4)
            {
                Console.WriteLine("Ulang Sampai Lulus" + ulang);
                ulang++;
            }
            Console.Read();
        }
    }
}
