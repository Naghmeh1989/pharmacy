using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface ITransactionRepository
    {
        List<Transaction> GetAll();
    }
}
