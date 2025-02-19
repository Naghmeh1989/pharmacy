using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IPriceHistoryRepository
    {
        List<PriceHistory> GetAll();
        PriceHistory? GetById(int id);
        PriceHistory Create(PriceHistory priceHistory);
        PriceHistory? Delete(int id);
        PriceHistory? Update(int id,PriceHistory priceHistory);
    }
}
