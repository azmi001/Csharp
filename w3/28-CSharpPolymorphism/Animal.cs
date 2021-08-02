using System;

namespace _28_CSharpPolymorphism
{
    public class Animal // Base class (parent)
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal make a sound");
        }
        
    }
}