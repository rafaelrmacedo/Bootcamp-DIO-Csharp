using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module3_ExploringExamples.Models
{
    public class Course
    {
        public string Name { get; set; }

        public List<Person> Students { get; set; }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int GetNumberOfStudentsEnrolled()
        {
            int AmountofStudents = Students.Count;
            return AmountofStudents;
        }

        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student); 
        }

        public void ListStudents()
        {

            Console.WriteLine($"{Name} course students:");

            for (int count = 0; count < Students.Count; count++)
            {
                // concatenação -> string text = "Student number " + count + " - " + Students[count].CompleteName;
                string text = $"Student number {count + 1} - {Students[count].CompleteName}"; // <- interpolação
                Console.WriteLine(text);
            }
        }
    }
}