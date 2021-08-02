using System;

namespace _28_CSharpPolymorphism
{
    public class Pig : Animal // Devired class (child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}