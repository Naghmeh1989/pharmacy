using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class TransactionStatusRepository : ITransactionStatusRepository
    {
        private readonly PharmacyDbContext dbContext;

        public TransactionStatusRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public TransactionStatus Create(TransactionStatus transactionStatus)
        {
            dbContext.TransactionStatuses.Add(transactionStatus);
            dbContext.SaveChanges();
            return transactionStatus;
        }

        public TransactionStatus? Delete(int id)
        {
            var transactionStatus = dbContext.TransactionStatuses.Find(id);
            if (transactionStatus == null) 
            { 
                return null;
            }
            dbContext.TransactionStatuses.Remove(transactionStatus);
            dbContext.SaveChanges();
            return transactionStatus;
        }

        public List<TransactionStatus> GetAll()
        {
            return dbContext.TransactionStatuses.ToList();
        }

        public TransactionStatus? GetById(int id)
        {
            return dbContext.TransactionStatuses.Find(id);
        }

        public TransactionStatus? Update(int id, TransactionStatus transactionStatus)
        {
            var existingTransactionStatus = dbContext.TransactionStatuses.Find(id);
            if (existingTransactionStatus == null)
            {
                return null;
            }
            existingTransactionStatus.CreatedBy = transactionStatus.CreatedBy;
            existingTransactionStatus.CreatedDate = transactionStatus.CreatedDate;
            existingTransactionStatus.ModifiedBy = transactionStatus.ModifiedBy;
            existingTransactionStatus.ModifiedDate = transactionStatus.ModifiedDate;
            existingTransactionStatus.Status = transactionStatus.Status;
            dbContext.SaveChanges();
            return existingTransactionStatus;
        }
    }
}
