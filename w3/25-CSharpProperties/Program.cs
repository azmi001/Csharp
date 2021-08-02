using System;
/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 27 - 01 - 2021
Pembelajaran : OOP
*/
namespace _25_CSharpProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
}
