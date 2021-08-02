using System;

namespace _05_CSharpTypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mengkonvert ke variable data lain

            int myInt = 9;
            double myDouble = myInt;// Mengkonvert int ke double
            Console.WriteLine("Hasil int 1 = " + myInt);      // Output 9
            Console.WriteLine("Hasil double 1 = " + myDouble);// Output 9

            double myDouble2 = 9.78;// Output 9.78
            int myInt2 = (int) myDouble2;// Manual Casting : double ke int
            Console.WriteLine("hasil doble 2 = " + myDouble2);// Output 9.78
            Console.WriteLine("hasil int 2 = " + myInt2);// Output 9

            int myInt3 = 30;
            double myDouble3 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt3));// Convert int ke string
            Console.WriteLine(Convert.ToDouble(myInt3));// convert int ke double
            Console.WriteLine(Convert.ToInt32(myDouble3));// convert double ke int
            Console.WriteLine(Convert.ToString(myBool));// convert bool ke string
        }
    }
}