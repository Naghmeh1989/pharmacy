using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IPriceHistoryRepository
    {
        List<PriceHistory> GetAll();
    }
}
