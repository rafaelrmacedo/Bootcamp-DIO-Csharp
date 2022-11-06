namespace module4.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory) {}

        public override void InstallApp(string nameApp)
        {
            Console.WriteLine("Opening the App Store...");
            Console.WriteLine("Installing " + nameApp);
            Console.WriteLine("Enter to confirm:");
            Console.ReadLine();
            Console.WriteLine("Percentage of instalation already completed: 20%");
            Console.WriteLine("Percentage of instalation already completed: 40%");
            Console.WriteLine("Percentage of instalation already completed: 60%");
            Console.WriteLine("Percentage of instalation already completed: 80%");
            Console.WriteLine("Percentage of instalation already completed: 100%");
            Console.WriteLine($"The app {nameApp} in Iphone was installed");
        }
    }
}