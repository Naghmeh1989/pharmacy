using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class ProductTagRepository : IProductTagRepository
    {
        private readonly PharmacyDbContext dbContext;

        public ProductTagRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<ProductsTag> GetAll()
        {
            return dbContext.ProductsTags.ToList();
        }
    }
}
