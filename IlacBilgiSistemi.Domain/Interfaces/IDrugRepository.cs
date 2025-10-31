using IlacBilgiSistemi.Domain.Entities;

namespace IlacBilgiSistemi.Domain.Interfaces;

public interface IDrugRepository
{
    Task<List<Drug>> GetAllAsync(int page = 1, int pageSize = 1000, CancellationToken cancellationToken = default);
    Task<Drug?> GetByIdAsync(string barkod, CancellationToken cancellationToken = default);
    Task<int> GetTotalCountAsync(CancellationToken cancellationToken = default);
}

