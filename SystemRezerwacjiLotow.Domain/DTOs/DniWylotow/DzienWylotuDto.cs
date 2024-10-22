using SystemRezerwacjiLotow.Domain.Models;

namespace SystemRezerwacjiLotow.Domain.DTOs.DniWylotow
{
    /// <summary>
    /// Obiekt uczestniczący w przekazywaniu oraz zwracaniu danych w kontrolerach, serwisach oraz repozytoriach
    /// </summary>
    public class DzienWylotuDto : BaseModel
    {
        public string? DzienWylotuId { get; set; }
        public string? Dzien { get; set; }
        public string? FlightId { get; set; }
    }
}
