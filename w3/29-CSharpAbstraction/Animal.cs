using System;

namespace _29_CSharpAbstraction
{
    abstract class Animal
    {
        // Abstarct method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("zzz");
        }
    }
}