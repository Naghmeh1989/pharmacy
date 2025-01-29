using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PharmacyDbContext dbContext;

        public UserRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<User> GetAll()
        {
            return dbContext.Users.ToList();
        }
    }
}
