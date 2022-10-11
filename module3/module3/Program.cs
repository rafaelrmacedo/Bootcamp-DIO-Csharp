List<string> stringList = new List<string>();

stringList.Add("RS");
stringList.Add("SC");
stringList.Add("PR");

Console.WriteLine($"Itens on the list: {stringList.Count} - List Capacity: {stringList.Capacity}");

stringList.Add("RJ");

Console.WriteLine($"Itens on the list: {stringList.Count} - List Capacity: {stringList.Capacity}");

stringList.Add("MG");

Console.WriteLine($"Itens on the list: {stringList.Count} - List Capacity: {stringList.Capacity}");

stringList.Remove("MG");

Console.WriteLine($"Itens on the list: {stringList.Count} - List Capacity: {stringList.Capacity}");


// for(int i = 0; i < stringList.Count; i++) //Count === Length
// {
//     Console.WriteLine($"Position number {i}: {stringList[i]}");
// }

// Console.WriteLine("==============================================");

// int j = 0;
// foreach(string value in stringList)
// {
//     Console.WriteLine($"Position number {j}: {value}");
//     j++;
// }


























// int[] array = {1, 2, 3, 4, 5, 6};
// int i = 0;

// //Array.Resize(ref array, array.Length + 5);

// //Using the for to loop through the array
// Console.WriteLine("For:");
// for(i = 0; i < array.Length; i++)
// {
//     Console.WriteLine($"Position number {i} - {array[i]}");
// }

// // Console.WriteLine("------------------------------------------------------");

// // //Using the foreach to loop through the array
// // Console.WriteLine("Foreach:");
// // foreach(int value in array)
// // {
// //     Console.WriteLine($"Position number {i} - {value}");
// //     i++;
// // }



























// // using module3.Commom.Models;

// // Person person = new Person();

// // string? option;
// // bool show = true; 

// // while(show)
// // {

// //     Console.WriteLine("Type your option: ");
// //     Console.WriteLine("1 - Customer Register");
// //     Console.WriteLine("2 - Search Customer");
// //     Console.WriteLine("3 - Delete Customer");
// //     Console.WriteLine("4 - Exit");

// //     option = Console.ReadLine();

// //     switch(option)
// //     {
// //         case "1": 
// //             Console.WriteLine("Customer Register");
// //             break;
        
// //         case "2": 
// //             Console.WriteLine("Search Customer");
// //             break;

// //         case "3": 
// //             Console.WriteLine("Delete Customer");
// //             break;

// //         case "4": 
// //             Console.WriteLine("Exit");
// //             //Environment.Exit(0); Here, the program will close HERE. 
// //             show = false; //But here, it'll close. But HERE, the program still can read the "Console.WriteLine("The program was closed.");"
// //             break;   

// //         default:
// //             Console.WriteLine("Please, choose a valid option."); 
// //             break;
// //     }

// // }

// // Console.WriteLine("The program was closed.");























// // int sum = 0, number = 0;

// // do
// // {

// //     Console.WriteLine("Type a number (0 to stop)");
// //     number = Convert.ToInt32(Console.ReadLine());
// //     sum += number;

// // } while(number != 0);

// // Console.WriteLine($"the sum total of all the numbers is: {sum}");

// // using module_3.models;

// // DateTime dateTime = DateTime.Now.AddMinutes(10);

// // Console.WriteLine(dateTime//.ToString("dd/MM/yyyy")
// // );

// // int numero = 6;

// // for(int i = 0; i < 11; i++)
// // {
// //     Console.WriteLine($"{numero} x {i} = {numero * i}");
// // }


// // 

// // person.Presentation();