using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PharmacyDbContext dbContext;

        public CategoryRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Category> GetAll()
        {
            return dbContext.Categories.ToList();
        }
    }
}
