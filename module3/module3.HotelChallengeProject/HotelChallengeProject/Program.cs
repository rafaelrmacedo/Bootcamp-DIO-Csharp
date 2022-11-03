using System.Text;
using HotelChallengeProject.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Person> guests = new List<Person>();

Person person1 = new Person(name: "Andreivi");
Person person2 = new Person(name: "Cheila");
Person person3 = new Person(name: "Rafael");
Person person4 = new Person(name: "Alice");

guests.Add(person1);
guests.Add(person2);
guests.Add(person3);
guests.Add(person4);

// Cria a suíte
Suite suite = new Suite(suiteType: "VIP", capacity: 4, dailyValue: 40);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reservation reservation = new Reservation(reservedDays: 5);
reservation.SuiteRegister(suite);
reservation.GuestsRegister(guests);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Number of Guests: {reservation.GetGuestsNumber()}");
Console.WriteLine($"Daily Value: {reservation.DailyValueCalculate()}");