using System;
/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 31 - 01 - 2021
Pembelajaran : OOP
*/
namespace _37_Exceptions_TryCatch2
{
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Acces denied - you must be at least 18 years old");
            }
            else
            {
                Console.WriteLine("Acces granted - you are old enough!");
            }
        }

        static void Main(string[] args)
        {
            //checkAge(15);
            checkAge(20);
        }
    }
}
