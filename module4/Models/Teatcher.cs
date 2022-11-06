using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module4.Models
{
    public class Teatcher : Person
    {
        public Teatcher() {}
        public Teatcher(string name) : base(name) {}
        // : base(name) make the Student class send the name to the Person class as well
        public decimal Salary { get; set; }

        public override sealed void Presentation()
        {
            Console.WriteLine($"Hi! I'm teatcher {Name}, and I've {Age} years old");
        }
    }
}