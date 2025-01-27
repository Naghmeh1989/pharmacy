using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLCategoryRepository : ICategoryRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLCategoryRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Category> GetAll()
        {
            return dbContext.Categories.ToList();
        }
    }
}
