using System;
/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 30 - 01 - 2021
Pembelajaran : OOP
*/
namespace _27_CSharpInheretence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (from the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the vehicle class) and the value of them modelName from the Car class

            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
