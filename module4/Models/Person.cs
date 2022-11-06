using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module4.Models
{
    public class Person
    {
        public Person() {}
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Presentation()
        {
            Console.WriteLine($"Hi! My name is {Name} and I'm {Age} years old.");
        }
    }
}