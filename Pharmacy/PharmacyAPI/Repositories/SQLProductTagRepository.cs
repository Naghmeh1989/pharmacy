using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLProductTagRepository : IProductTagRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLProductTagRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<ProductsTag> GetAll()
        {
            return dbContext.ProductsTags.ToList();
        }
    }
}
