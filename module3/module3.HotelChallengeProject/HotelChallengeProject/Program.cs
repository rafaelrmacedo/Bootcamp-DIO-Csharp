using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Person> guests = new List<Person>();

Person person1 = new Person(name: "Guest 1");
Person person2 = new Person(name: "Guest 2");

guests.Add(person1);
guests.Add(person2);

// Cria a suíte
Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyValue: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reservation reservation = new Reservation(reservedDays: 5);
reservation.SuiteRegister(suite);
reservation.GuestsRegister(guests);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Number of Guests: {reservation.GetGuestsNumber()}");
Console.WriteLine($"Daily Value: {reservation.DailyValueCalculate()}");