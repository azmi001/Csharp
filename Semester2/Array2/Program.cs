using System;
/*
Nama 	: Azmi Munif Hartono
NIM 	: 20210012
Kelas 	: Gametech 2B
Tugas	: C# Latihan Array 2
Tanggal : 09 - 16 - 2021
*/
namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int [][]{new int[]{0,0},new int[]{15,32},new int[]{54,32},new int[]{21,76},new int[]{22,12}};
            int i, j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}",i,j,a[i][j]);
                }
            }
            Console.ReadLine();
        }
    }
}
