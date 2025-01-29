using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly PharmacyDbContext dbContext;

        public AddressRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Address> GetAll()
        {
            return dbContext.Addresses.ToList();
        }
    }
}
