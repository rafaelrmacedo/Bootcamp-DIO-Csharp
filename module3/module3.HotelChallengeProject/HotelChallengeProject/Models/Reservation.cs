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
                Guests = guests;
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
            return Guests.Count();
        }

        public decimal DailyValueCalculate()
        {
            decimal value = 0;

            if (ReservedDays >= 10)
            {
                value = Suite.DailyValue * ReservedDays - (Suite.DailyValue * 0.1M * ReservedDays);
            }
            else
            {
                value = Suite.DailyValue * ReservedDays;
            }

            return value;

        }
    }
}