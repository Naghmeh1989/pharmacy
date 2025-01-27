using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface ITransactionStatusRepository
    {
        List<TransactionStatus> GetAll();
    }
}
