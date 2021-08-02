using System;

namespace _30_CSharpInterface
{
    class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animaslSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}