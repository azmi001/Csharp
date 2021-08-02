using System;

namespace _09_CSharpString
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string txt = " ABCDEFGHIJKLMNOPKRSTUVWZYX";
            string txt2 = "Hello World";
            string firstName = "Azmi ";
            string lastName = "Munif";
            string name = firstName + lastName;
            string firstName2 = "Umar";
            string lastName2 = "Ahmad";
            string name2 = $"Nama lengkap saya adalah : {firstName2} {lastName2}";
            Console.WriteLine(greeting);
            Console.WriteLine("Panjang sebuah text string adalah : " + txt.Length);
            Console.WriteLine(txt2.ToUpper());
            Console.WriteLine(txt2.ToLower());
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(greeting[0]);
            Console.WriteLine(greeting[1]);
            Console.WriteLine(greeting.IndexOf("e"));

            /*
            string txt3 = ""We are the so-called "Vikings" from the north.";
            bakal nyiptain error karena (") harus pake \ biar gak error
            */

            string txt3 = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt3);

            string txt4 = "It\'s alright.";
            Console.WriteLine(txt4);

            string txt5 = "The character \\ is called backslash.";
            Console.WriteLine(txt5);

            int x1 = 10;
            int y1 = 20;
            int z1 = x1 + y1;
            Console.WriteLine(z1);

            string x2 = "10";
            string y2 = "20";
            string z2 = x2 + y2;
            Console.WriteLine(z2);
        }
    }
}