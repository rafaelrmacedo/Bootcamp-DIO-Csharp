using module3_ExploringExamples.Models;
using Newtonsoft.Json;

int a = 5;
int b = a;
b = 10;

Console.WriteLine($"Value A: {a}");
Console.WriteLine($"Value B: {b}");

Person person1 = new Person("Rafael", "Macedo");
Person person2 = person1;
person2.Name = "João";

Console.WriteLine($"Complete person1 name: {person1.CompleteName}");
Console.WriteLine($"Complete person2 name: {person2.CompleteName}");




































// Extensions methods

// var number = 15;
// bool isEven = false;

// // if ternary

// isEven = number.IsEven();

// Console.WriteLine($"Number {number} is " + (isEven ? "even" : "odd"));







































//Generic classes

// MyArray<string> stringArray = new MyArray<string>();

// stringArray.AddElement("Sim");

// MyArray<int> intArray = new MyArray<int>();

// intArray.AddElement(10);







































//dynamic variable

// dynamic dynamicVariable = 4;

// Console.WriteLine($"Variable type: {dynamicVariable.GetType()}, value: {dynamicVariable}");

// dynamicVariable = "Text";

// Console.WriteLine($"Variable type: {dynamicVariable.GetType()}, value: {dynamicVariable}");

// dynamicVariable = false;

// Console.WriteLine($"Variable type: {dynamicVariable.GetType()}, value: {dynamicVariable}");



















// string content = File.ReadAllText("Archives/sells.json");

// List<Sell> sellList = JsonConvert.DeserializeObject<List<Sell>>(content);

// var anonimousList = sellList.Select(x => new { x.Product, x.Price, x.Discount });

// foreach(var sell in anonimousList)
// {
//     Console.WriteLine(sell);
// }





































// bool? wantReceiveEmail = true;

// if(wantReceiveEmail.HasValue && wantReceiveEmail.Value)
// {
//     Console.WriteLine("Customer wants to receive e-mails.");
// }
// else
// {
//     Console.WriteLine("Customer doesn't respond or he doesn't want receive e-mails.");
// }

// string content = File.ReadAllText("Archives/sells.json");

// List<Sell> sellList = JsonConvert.DeserializeObject<List<Sell>>(content);

// foreach(Sell sell in sellList)
// {
//     Console.WriteLine($"Id: {sell.Id}, Product: {sell.Product}, Price: {sell.Price}, SellDate: {sell.SellDate} {(sell.Discount.HasValue ? $",Discount: {sell.Discount}" : "")}");
// }


































//Serialization to JSON

// DateTime CurrentDate = DateTime.Now;

// List<Sell> sellsList = new List<Sell>();

// Sell sell1 = new Sell(1, "Ferrari Italy", 2500000.00M, CurrentDate);
// Sell sell2 = new Sell(2, "Software Licence", 100.00M, CurrentDate);

// sellsList.Add(sell1);
// sellsList.Add(sell2);

// string Serialization = JsonConvert.SerializeObject(sellsList, Formatting.Indented);

// File.WriteAllText("Archives/sells.json", Serialization);

































// var number = 15;
// bool isEven = false;

// // if ternary

// isEven = number.IsEven();

// Console.WriteLine($"Number {number} is " + (isEven ? "even" : "odd"));

// // if(number % 2 == 0)
// // {
// //     Console.WriteLine("Even number");
// // }
// // else
// // {
// //     Console.WriteLine("Odd number");
// // }




































// Person person = new Person("Rafael", "Macedo");

// (string name, string lastName) = person;





































// ReadingFile readingFile = new ReadingFile();

// //The _ say to the code for discard the information that tuple returns
// var (success, Lines, _) = readingFile.ReadFile("Archives/text.txt");

// if(success)
// {
//     //Console.WriteLine("Archive lines quantity: " + linesQuatity);
//     foreach(string line in Lines)
//     {
//         Console.WriteLine(line);
//     }
// }
// else 
// {
//     Console.WriteLine("Can't read file.");
// }


































// //Tuple practice

// (int id, string name, string lastName) Tuple = (1, "Rafael", "Macedo"); //Best way to declare a tuple

// //Another Tuple sintax

// ValueTuple<int, string, string> Tuple2 = (1, "Rafael", "Macedo");

// Console.WriteLine($"First tuple informations: {Tuple.id}, {Tuple.name}, {Tuple.lastName}");






























// Dictionary<string, string> dictionary = new Dictionary<string, string>();

// dictionary.Add("RS", "Rio Grande do Sul");
// dictionary.Add("SC", "Santa Catarina");
// dictionary.Add("PR", "Paraná");

// foreach(var item in dictionary)
// {
//     Console.WriteLine($"Key: {item.Key}, item: {item.Value}");
// }

// dictionary.Remove("PR");
// dictionary.Add("SP", "São Paulo");





























// Stack<int> stack = new Stack<int>();

// Console.WriteLine("Stacked elements: ");
// stack.Push(2);
// stack.Push(4);
// stack.Push(6);
// stack.Push(8);
// stack.Push(10);

// foreach(int item in stack)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"{stack.Pop()} was removed from the stack.");

// Console.WriteLine("New stack: ");

// foreach(int item in stack)
// {
//     Console.WriteLine(item);
// }


























// Queue<int> queue = new Queue<int>();

// queue.Enqueue(1);
// queue.Enqueue(2);
// queue.Enqueue(3);
// queue.Enqueue(4);
// queue.Enqueue(5);
// queue.Enqueue(6);

// foreach (int item in queue)
// {
//     Console.WriteLine(item);
// }

// queue.Dequeue();
















// new ExamplesException().Method1();

// try
// {
//     string[] lines = File.ReadAllLines("");

//     foreach(string line in lines)
//     {
//         Console.WriteLine(line);
//     }

// }
// catch(FileNotFoundException exception)
// {
//     Console.WriteLine($"An exception occurred. File not found. {exception.Message}");
// }
// catch(DirectoryNotFoundException exception)
// {
//     Console.WriteLine($"An exception occurred. Directory not found.{exception.Message}");
// }
// catch(ArgumentException exception)
// {
//     Console.WriteLine($"An exception occurred. You didn't type a valid argument. {exception.Message}");
// }
// catch(Exception exception)
// {
//     Console.WriteLine($"A generic exception occurred. {exception.Message}");
// }
// //Finally will occurred always. Regardless of whether there is an exception or not.
// finally
// {

// }


































// //Here, without decare any culture, the writeline will print the money in my current system config
// decimal monetaryitem2 = 22382.40M;

// Console.WriteLine($"{monetaryitem2:C}");
// //C = currency, country currency coin

// //This constructor is used for "change" the machine localization
// //Here, the writeline will print in Reais
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// decimal monetaryitem = 22382.40M;

// Console.WriteLine($"{monetaryitem:C}");
// //C = currency, country currency coin

// //We can choose an especific culture to print the money on just 1 line
// //ja-JA is Japonese
// Console.WriteLine(monetaryitem2.ToString("C", CultureInfo.CreateSpecificCulture("ja-JA")));

// DateTime dateTime = DateTime.Now;

// Console.WriteLine(dateTime.ToString("MM/dd/yyyy HH:mm"));

// string dateString = "2022/10/22 16:30";

// bool success = DateTime.TryParseExact(dateString, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date); 

// if(success)
// {
//     Console.WriteLine($"Valid Date! Variable was parsed. Date: {date}");
// }
// else 
// {
//     Console.WriteLine($"{dateString} <= This date isn't a valid date.");
// }
























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