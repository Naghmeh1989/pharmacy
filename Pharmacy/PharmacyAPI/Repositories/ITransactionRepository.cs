using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface ITransactionRepository
    {
        List<Transaction> GetAll();
        Transaction? GetById(int id);
        Transaction Create(Transaction transaction);
        Transaction? Delete(int id);
        Transaction? Update(int id,Transaction transaction);
    }
}
