using System;

namespace module_3.models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Presentation()
        {
            Console.WriteLine("$Hi! My name is {Name}, and I have {Age} years old.");
        }
    }
}