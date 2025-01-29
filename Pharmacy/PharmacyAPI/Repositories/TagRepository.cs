using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    
    public class TagRepository : ITagRepository
    {
        private readonly PharmacyDbContext dbContext;

        public TagRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Tag> GetAll()
        {
            return dbContext.Tags.ToList();
        }
    }
}
