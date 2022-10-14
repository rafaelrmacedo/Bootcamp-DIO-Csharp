namespace module3Challenge.Models
{
    public class Parking
    {
        private decimal inicialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicle = new List<string>();
        string licencePlate = "";

        public Parking(decimal inicialPrice, decimal pricePerHour)
        {
            this.inicialPrice = inicialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
    
            Console.WriteLine("Type the licence plate to park the vehicle:");
            licencePlate = Console.ReadLine();

            vehicle.Add(licencePlate);
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Type the vehicle licence plate to remove:");

            string licencePlate = Console.ReadLine();

            // Verify if the vehicle exists
            if (vehicle.Any(x => x.ToUpper() == licencePlate.ToUpper()))
            {
                Console.WriteLine("Type how much hours that vehicle was parked:");
                int hours = Convert.ToInt32(Console.ReadLine());

                decimal totalPrice = inicialPrice + pricePerHour * hours;

                vehicle.Remove(licencePlate);

                Console.WriteLine($"The vehicle {licencePlate} was removed and the total price is: $ {totalPrice}");
            }
            else
            {
                Console.WriteLine("Sorry, this vehicle isn't park here. Verify the if the licence plate was typed correctly.");
            }
        }

        public void ListVehicle()
        {
            if (vehicle.Any())
            {
                Console.WriteLine("The park vehicles is:");

                // Loop for show all vehicles in the list
                vehicle.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Don't have any parked cars here.");
            }
        }
    }
}
