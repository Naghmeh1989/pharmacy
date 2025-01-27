using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLUserRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<User> GetAll()
        {
            return dbContext.Users.ToList();
        }
    }
}
