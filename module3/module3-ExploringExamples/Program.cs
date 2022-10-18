using module3_ExploringExamples.Models;

Person person1 = new Person(name: "Rafael", lastName: "Macedo");
person2.Age = 40;

Person person2 = new Person("Andreivi", "Macedo");
person1.Age = 18;

Course course1 = new Course();
course1.Name = "C#";
course1.Students = new List<Person>();
course1.AddStudent(person1);
course1.AddStudent(person2);
course1.ListStudents();