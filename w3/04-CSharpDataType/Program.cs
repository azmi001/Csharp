using System;

namespace _04_CSharpDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String
            Console.WriteLine("\n" + myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText + "\n");
            /*
            Long

            he long data type can store whole numbers from -9223372036854775808 to 9223372036854775807. This is used when int is not large enough to store the value. Note that you should end the value with an "L":
            */
            long myNum1 = 15000000000L;
            Console.WriteLine(myNum1 + "\n");
            /*
            Floating Point Types
            You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.

            Float
            The float data type can store fractional numbers from 3.4e−038 to 3.4e+038. Note that you should end the value with an "F":
            */
            float myNum2 = 5.75F;
            Console.WriteLine(myNum2 + "\n");
            /*
            Double
            The double data type can store fractional numbers from 1.7e−308 to 1.7e+308. Note that you can end the value with a "D" (although not required):
            */
            double myNum3 = 19.99D;
            Console.WriteLine(myNum3 + "\n");
            /*
            Use float or double?

            The precision of a floating point value indicates how many digits the value can have after the decimal point. The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits. Therefore it is safer to use double for most calculations.

            Scientific Numbers
            
            A floating point number can also be a scientific number with an "e" to indicate the power of 10:
            */
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            Console.ReadLine(); //jika menggunakan cmd biasa maka akan langsung ketutup untuk mencegahnya menggunakan script readline ini
        }
    }
}