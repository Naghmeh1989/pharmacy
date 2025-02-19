using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface ITransactionStatusRepository
    {
        List<TransactionStatus> GetAll();
        TransactionStatus? GetById(int id);
        TransactionStatus Create(TransactionStatus transactionStatus);
        TransactionStatus? Delete(int id);
        TransactionStatus? Update(int id,TransactionStatus transactionStatus);
    }
}
