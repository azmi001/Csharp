using System;
using System.IO;
/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 31 - 01 - 2021
Pembelajaran : OOP
*/
namespace _35_CSharpFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!"; // Create a text string
            File.WriteAllText("filename.txt", writeText); // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }
    }
}
