using System;
/*
Nama Pembuat : Azmi Munif Hartono
Tanggal Pembuatan : 31 - 01 - 2021
Pembelajaran : OOP
*/
namespace _29_CSharpAbstraction
{
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}