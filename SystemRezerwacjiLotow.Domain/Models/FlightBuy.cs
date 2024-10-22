using System.ComponentModel.DataAnnotations;

namespace SystemRezerwacjiLotow.Domain.Models
{
    /// <summary>
    /// Model przechowywujący dane związane z kupnem biletu, użytkownik może zdecydować ile chce kupić biletów, potem ta ilość jest mnożona przez cenę biletu,
    /// potem w logice aplikacji jest analizowane czy tenantowi przysługuje zniżka, oraz ile ich przysługuje. Logika za to odpowiedzialna jest zrealizowana
    /// w FlightsRepository. Na dzień dobry tworzone są konta użytkowników w ApplicationDbContext, którym urodziny wypadają na "dzisiaj", więc z góry realizowane jest założenie
    /// związane z przydzieleniem zniżki z okazji dnia urodzin. Druga zniżka zależy od tego czy tenant wybierze lot do Afryki. Przykładowe dane definiowane są w bazie od razu
    /// po utworzeniu migracji.
    /// </summary>
    public class FlightBuy
    {
        [Key]
        public string FlightBuyId { get; private set; }

        public int IloscBiletow { get; private set; }
        public double PriceSuma { get; private set; }
	    public string DataZakupu { get; private set; }


        public string? FlightId { get; private set; }
        public Flight? Flight { get; private set; }


        public string? TenantId { get; private set; }
        public Tenant? Tenant { get; private set; }



        // Relacja wiele-do-wielu
        public List<FlightBuyKryteriaZnizki>? FlightBuysKryteriaZnizkis { get; private set; }



        public FlightBuy(int iloscBiletow, double priceSuma, string flightId, string tenantId)
        {
            FlightBuyId = Guid.NewGuid().ToString();
            IloscBiletow = iloscBiletow;
            PriceSuma = priceSuma;
            FlightId = flightId;
            TenantId = tenantId;
            DataZakupu = DateTime.Now.ToString();
        }

        public void Update (int iloscBiletow, double priceSuma)
        {
            IloscBiletow = iloscBiletow;
            PriceSuma = priceSuma;
        }

    }
}
