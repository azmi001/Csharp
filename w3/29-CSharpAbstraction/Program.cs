using System;

namespace _29_CSharpAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound(); // Call the abstrack method
            myPig.sleep(); // Call the regular method
        }
    }
}
