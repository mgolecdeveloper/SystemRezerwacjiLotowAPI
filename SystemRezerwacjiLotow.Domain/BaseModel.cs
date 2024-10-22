namespace SystemRezerwacjiLotow.Domain
{
    /// <summary>
    /// Model bazowy przypisywany do każdego obiektu DTO, jeżeli jedna z operacji CRUD
    /// powiedzie się sukcesem wtedy zwracany jest true lub false przy obiekcie Success, w przeciwnym razie
    /// obiekt Message otrzymuje komunikat przekazywany m.in. przez Catch...Exception..., potem można go odczytać np w Angular na jakimś widoku
    /// </summary>
    public class BaseModel
    {
        public string? Message { get; set; } // informacja zwracana gdy np rekord w bazie nie został odnaleziony, lub wystąpił jakiś inny wyjątek
        public bool Success { get; set; } // jeżeli operacja na bazie się powiedzie, zwracany jest sukces
    }
}
