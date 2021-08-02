using System;
/*
Nama 	: Azmi Munif Hartono
NIM 	: 20210012
Kelas 	: Gametech 2B
Tugas	: C# Latihan perulangan for
Tanggal : 09 - 16 - 2021
*/
namespace perulanganfor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seluruh nilai yang anda kumpulkan");
            for (int nilai = 1; nilai <= 10; nilai++)
            {
                Console.WriteLine("nilai ke : "+nilai.ToString());
            }
            Console.Read();
        }
    }
}
