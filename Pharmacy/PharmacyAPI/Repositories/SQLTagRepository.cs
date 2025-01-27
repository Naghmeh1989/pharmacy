using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    
    public class SQLTagRepository : ITagRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLTagRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Tag> GetAll()
        {
            return dbContext.Tags.ToList();
        }
    }
}
