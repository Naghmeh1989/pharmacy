using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLAddressRepository : IAddressRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLAddressRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Address> GetAll()
        {
            return dbContext.Addresses.ToList();
        }
    }
}
