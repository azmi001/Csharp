using System;   

namespace _28_CSharpPolymorphism
{
    public class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }
}