namespace IlacBilgiSistemi.Domain.Interfaces;

public class StatsData
{
    public int TotalDrugs { get; set; }
    public int UniqueIngredients { get; set; }
    public int UniqueCompanies { get; set; }
    public int RadioCount { get; set; }
    public int AllergenCount { get; set; }
}

public interface IStatsService
{
    Task<StatsData> GetStatsAsync(CancellationToken cancellationToken = default);
}

