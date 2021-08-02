using System;
/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 31 - 01 - 2021
Pembelajaran : OOP
*/
namespace _36_Exceptions_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumber = {1, 2, 3};
                Console.WriteLine(myNumber[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something Went Wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished");
            }
        }
    }
}
