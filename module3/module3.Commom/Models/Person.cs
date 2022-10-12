using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module3.Commom.models
{
    /// <summary>
    /// A classe é uma coisa bonita
    /// </summary>
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // Da para utilizar o "paramname" para explicar sobre o parâmetro
        // E também o return, dizendo o que se espera que seja retornado
        
        public void Presentation()
        {
            Console.WriteLine($"Hi! My name is {Name}, and I have {Age} years old.");
        }
    }
}