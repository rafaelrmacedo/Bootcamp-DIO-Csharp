namespace DesafioProjetoHospedagem.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void GuestsRegister(List<Person> guests)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (true)
            {
                Guests = guests;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
            }
        }

        public void SuiteRegister(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestsNumber()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade guests)
            // *IMPLEMENTE AQUI*
            return 0;
        }

        public decimal DailyValueCalculate()
        {
            // TODO: Retorna o value da diária
            // Cálculo: DiasReservados X Suite valueDiaria
            // *IMPLEMENTE AQUI*
            decimal value = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (true)
            {
             value = 0;
            }

            return value;
        }
    }
}