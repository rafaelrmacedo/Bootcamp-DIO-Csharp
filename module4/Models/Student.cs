using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module4.Models
{
    public class Student : Person
    {
        public Student() {}
        public Student(string name) : base(name) {}
        // : base(name) make the Student class send the name to the Person class as well
        public decimal Grade { get; set; }

        public override void Presentation()
        {
            Console.WriteLine($"Hi! I'm student {Name}, and I've a {Grade} grade");
        }
    }
}