using IlacBilgiSistemi.Domain.Entities;

namespace IlacBilgiSistemi.Domain.Interfaces;

public interface IRadiopharmaRepository
{
    Task<List<Radiopharmaceutical>> GetAllAsync(CancellationToken cancellationToken = default);
}

