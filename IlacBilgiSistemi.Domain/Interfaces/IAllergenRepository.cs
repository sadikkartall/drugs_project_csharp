using IlacBilgiSistemi.Domain.Entities;

namespace IlacBilgiSistemi.Domain.Interfaces;

public interface IAllergenRepository
{
    Task<List<Allergen>> GetAllAsync(CancellationToken cancellationToken = default);
}

