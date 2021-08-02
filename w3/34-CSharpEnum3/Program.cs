using System;
/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 31 - 01 - 2021
Pembelajaran : OOP
*/
namespace _34_CSharpEnum3
{
    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            switch(myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }
        }
    }
}
    