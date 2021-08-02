using System;

namespace _25_CSharpProperties
{
    public class Person
    {
        private string name; //field

        public string Name
        {
            get { return name; } // get method Read only
            set { name = value; } // set method write only
        }
    }
}