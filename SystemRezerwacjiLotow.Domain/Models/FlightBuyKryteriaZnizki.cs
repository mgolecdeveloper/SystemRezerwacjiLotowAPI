using System.ComponentModel.DataAnnotations;

namespace SystemRezerwacjiLotow.Domain.Models
{
    /// <summary>
    /// Dzięki temu obiektowi realizowana jest relacja typu wiele-do-wielu w bazie. Ten obiekt mówi o tym do którego zakupu przypisać którą zniżkę.
    /// Do jednego zakupu biletu możemy przypisywać większą ilość zniżek (urodziny, afryka), ich ilość zależy od tego ile ich zdefiniujemy w bazie. Na dzień dobry
    /// są dwa wpisy "Urodziny kupującego" oraz "Lot do Afryki". 
    /// </summary>
    public class FlightBuyKryteriaZnizki
    {
        [Key]
        public string FlightBuyId { get; private set; }
        public FlightBuy FlightBuy { get; private set; }


        public string KryteriaZnizkiId { get; private set; }
        public KryteriaZnizki KryteriaZnizki { get; private set; }


        public FlightBuyKryteriaZnizki(string flightBuyId, string kryteriaZnizkiId)
        {
            FlightBuyId = flightBuyId;
            KryteriaZnizkiId = kryteriaZnizkiId;
        }
    }
}
