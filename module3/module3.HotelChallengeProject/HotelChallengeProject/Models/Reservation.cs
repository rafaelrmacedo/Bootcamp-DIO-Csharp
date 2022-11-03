namespace HotelChallengeProject.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Reservation(Suite suite) 
        {
            this.Suite = suite;
   
        }
                public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void GuestsRegister(List<Person> guests)
        {
            if (guests.Count() <= Suite.Capacity)
            {
                Guests = guest;
            }
            else if(guests.Count() > Suite.Capacity)
            {
                throw new ArgumentException("The numbers of guest can't be more than the suite capacity.");
            }
        }

        public void SuiteRegister(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestsNumber()
        {
            Guests = guests;
            return Guests;
        }

        public decimal DailyValueCalculate()
        {
            decimal value = 0;

            if (ReservedDays >= 10)
            {
                value = Suite.DailyValue - Suite.DailyValue - Suite.DailyValue * (10/100) * ReservedDays;
            }
            else
            {
                value = Suite.DailyValue * ReservedDays;
            }

            return value;

        }
    }
}