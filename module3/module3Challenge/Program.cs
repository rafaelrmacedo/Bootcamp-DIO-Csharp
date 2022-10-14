using module3Challenge.Models;

// Put the encoding to UTF8 for show accent (pt-BR)
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal inicialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Welcome to the Parking System!\n" +
                  "Type an inicial price for the car that will park:");
inicialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now type the price per hour:"); pricePerHour = Convert.ToDecimal(Console.ReadLine());

Parking parking = new Parking(inicialPrice, pricePerHour);

string option = string.Empty;
bool showMenu = true;

// Realiza o loop do menu
while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Type your option:");
    Console.WriteLine("1 - Register Vehicle");
    Console.WriteLine("2 - Remove Vehicle");
    Console.WriteLine("3 - List Vehicles");
    Console.WriteLine("4 - Exit");

    switch (Console.ReadLine())
    {
        case "1":
            parking.AddVehicle();
            break;

        case "2":
            parking.RemoveVehicle();
            break;

        case "3":
            parking.ListVehicle();
            break;

        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    Console.WriteLine("Press enter to continue:");
    Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("The software was closed.");
