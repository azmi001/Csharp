using System;

/*
Nama 	: Azmi Munif Hartono
NIM 	: 20210012
Kelas 	: Gametech 2B
Tugas	: C# Latihan Penjumlahan
Tanggal : 09 - 02 - 2021
*/

namespace latihanjam
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime dt = DateTime.Now;
			Time1(dt);
			Time2(dt);
		}
		
		static void Time1(DateTime t)
		{
			Console.WriteLine("{0:D2} {1:D2} {2:D2} {3:D2}", t.Hour, t.Minute, t.Second, t.Millisecond);
		}
		
		static void Time2 (DateTime t)
		{
			Console.WriteLine(t.ToLongDateString());
			Console.WriteLine(t.ToLongTimeString());
		}
	}
}