using System.ComponentModel.DataAnnotations;

namespace SystemRezerwacjiLotow.Domain.Models
{
    /// <summary>
    /// W bazie zapisywane są dni wylotów takie jak "Poniedziałek", "Wtorek", "Środa", itd.
    /// Są one przypisane do "Flight" i mówią o tym w które dni dany lot się odbywa
    /// </summary>
    public class DzienWylotu
    {
        [Key]
        public string DzieWylotuId { get; private set; }
        public string Dzien { get; private set; }


        public string? FlightId { get; private set; }
        public Flight? Flight { get; private set; }

         
         
        public DzienWylotu(string dzien, string flightId)
        {
            DzieWylotuId = Guid.NewGuid().ToString();
            Dzien = dzien;
            FlightId = flightId;
        }


        public void Update (string dzien, string flightId)
        {
            Dzien = dzien;
            FlightId = flightId;
        }
    }
}
