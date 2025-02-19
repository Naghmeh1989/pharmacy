using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly PharmacyDbContext dbContext;

        public TransactionRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Transaction Create(Transaction transaction)
        {
            dbContext.Transactions.Add(transaction);
            dbContext.SaveChanges();
            return transaction;
        }

        public Transaction? Delete(int id)
        {
            var transaction = dbContext.Transactions.Find(id);
            if (transaction == null) 
            { 
                return null;
            }
            dbContext.Transactions.Remove(transaction);
            dbContext.SaveChanges();
            return transaction;
        }

        public List<Transaction> GetAll()
        {
            return dbContext.Transactions.ToList();
        }

        public Transaction? GetById(int id)
        {
            return dbContext.Transactions.Find(id);
        }

        public Transaction? Update(int id, Transaction transaction)
        {
            var existingTransaction = dbContext.Transactions.Find(id);
            if (existingTransaction == null)
            {
                return null;
            }
            existingTransaction.CreatedDate = transaction.CreatedDate;
            existingTransaction.ModifiedDate = transaction.ModifiedDate;
            existingTransaction.CreatedBy = transaction.CreatedBy;
            existingTransaction.ModifiedBy = transaction.ModifiedBy;
            existingTransaction.TotalAmount = transaction.TotalAmount;
            existingTransaction.TotalAmountAfterDiscount = transaction.TotalAmountAfterDiscount;
            existingTransaction.DiscountAmount = transaction.DiscountAmount;
            existingTransaction.TransactionStatusId = transaction.TransactionStatusId;
            dbContext.SaveChanges();
            return existingTransaction;
        }
    }
}
