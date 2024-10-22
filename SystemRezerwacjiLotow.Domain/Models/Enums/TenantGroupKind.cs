
namespace SystemRezerwacjiLotow.Domain.Models.Enums
{
    /// <summary>
    /// Tenant może występować w jednym z poniżej zdefiniowanych obiektów. Grupa do której będzie należał 
    /// przypisywana jest podczas tworzenia nowego Tenanta, odpowiedzialny jest za to serwis TenantsService w warstwie Aplikacji
    /// </summary>
    public enum TenantGroupKind
    {
        GroupA,
        GroupB
    }
}
