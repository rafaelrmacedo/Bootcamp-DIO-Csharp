using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module3_ExploringExamples.Models
{
    public class Person
    {
        public Person(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }
        public Person()
        {

        }

        public void Deconstruct(out string name, out string lastName)
        {
            name = Name;
            lastName = LastName;
        }

        private string _nome; //this fields that will store the name and age. Only the classe can modify
        private int _age;
        public string Name 
        { 
            
            get => _nome.ToUpper();
            // => mean return

            set
            {
                if(value == ""){
                    throw new ArgumentException("The name can't be null.");
                }

                _nome = value;
                //after set the name, the _nome property will store the value
            }  
        }

        public string LastName { get; set; }

        public string CompleteName => $"{Name} {LastName}";
        //without get and set explicitly written, the property still have only the get method

        public int Age 
        {
            get => _age;

            set
            {
                if(value < 0){
                    throw new ArgumentException("The age can't be < 0");
                }

                _age = value;
                //after set the age, the _age property will store the value
            }
        }


        public void Presentation()
        {
            Console.WriteLine($"Name: {CompleteName}, Age: {Age}");
        }
    }
}