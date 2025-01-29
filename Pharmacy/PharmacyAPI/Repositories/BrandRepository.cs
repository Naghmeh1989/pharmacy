using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLBrandRepository : IBrandRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLBrandRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Brand> GetAll()
        {
            return dbContext.Brands.ToList();
        }
    }
}
