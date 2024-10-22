
using SystemRezerwacjiLotow.Domain.Models;

namespace SystemRezerwacjiLotow.Domain.DTOs.KryteriaZnizek
{
    /// <summary>
    /// Obiekt uczestniczący w przekazywaniu oraz zwracaniu danych w kontrolerach, serwisach oraz repozytoriach
    /// </summary>
    public class KryteriaZnizkiDto : BaseModel
    {
        public string? KryteriaZnizkiId { get; set; }
        public string? Name { get; set; }
        public string? FlightBuyId { get; set; }
    }
}
