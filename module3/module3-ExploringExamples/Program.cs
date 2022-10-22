using module3_ExploringExamples.Models;
using System.Globalization;

//Here, without decare any culture, the writeline will print the money in my current system config
decimal monetaryValue2 = 22382.40M;

Console.WriteLine($"{monetaryValue2:C}");
//C = currency, country currency coin

//This constructor is used for "change" the machine localization
//Here, the writeline will print in Reais
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal monetaryValue = 22382.40M;

Console.WriteLine($"{monetaryValue:C}");
//C = currency, country currency coin

//We can choose an especific culture to print the money on just 1 line
//ja-JA is Japonese
Console.WriteLine(monetaryValue2.ToString("C", CultureInfo.CreateSpecificCulture("ja-JA")));

DateTime dateTime = DateTime.Now;

Console.WriteLine(dateTime.ToString("MM/dd/yyyy HH:mm"));

string dateString = "2022/10/22 16:30";

bool success = DateTime.TryParseExact(dateString, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date); 

if(success)
{
    Console.WriteLine($"Valid Date! Variable was parsed. Date: {date}");
}
else 
{
    Console.WriteLine($"{dateString} <= This date isn't a valid date.");
}
























// string number1 = "18";
// string number2 = "20";

// int result = number1 + number2;

// Console.WriteLine(result);










































// Person person1 = new Person(name: "Rafael", lastName: "Macedo");
// person1.Age = 40;

// Person person2 = new Person("Andreivi", "Macedo");
// person2.Age = 18;

// Course course1 = new Course();
// course1.Name = "C#";
// course1.Students = new List<Person>();
// course1.AddStudent(person1);
// course1.AddStudent(person2);
// course1.ListStudents();