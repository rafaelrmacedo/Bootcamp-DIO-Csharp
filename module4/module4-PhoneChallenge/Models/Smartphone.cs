namespace module4.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        private string Model { get; set; }
        private string IMEI { get; set; }
        private int Memory { get; set; }


        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;
        }

        public void Call(int callNumber)
        {
            Console.WriteLine($"Making call to number {callNumber}");
            Console.WriteLine("Call was finalized.");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receiving call...");
            Console.WriteLine("Call was finalized.");
        }

        public abstract void InstallApp(string nameApp);
    }
}