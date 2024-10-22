using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SystemRezerwacjiLotow.Domain.Models
{
    /// <summary>
    /// Encja przechowywująca dane w bazie dotyczące kryteriów, na dzień dobry są dwa wpisy "Urodziny kupującego" oraz "Lot do Artyki".
    /// Obsługa kryteriów logiki znajduje się w repozytorium FlightsRepository w metodzie "Create" w Infrastrukturze aplikacji
    /// </summary>
    public class KryteriaZnizki
    {
        [Key]
        public string? KryteriaZnizkiId { get; private set; }
        public string? Name { get; private set; }


        public string? FlightBuyId { get; private set; }
        public FlightBuy? FlightBuy { get; private set; }


        // relacja wiele-do-wielu
        public List<FlightBuyKryteriaZnizki>? FlightBuysKryteriaZnizkis { get; private set; }

         

        public KryteriaZnizki(string name)
        {
            KryteriaZnizkiId = Guid.NewGuid().ToString();
            Name = name;
        }

        public KryteriaZnizki(string name, string flightBuyId)
        {
            KryteriaZnizkiId = Guid.NewGuid().ToString();
            Name = name;
            FlightBuyId = flightBuyId;
        }



        public void Update (string name)
        {
            Name = name;
        }
    }
}
