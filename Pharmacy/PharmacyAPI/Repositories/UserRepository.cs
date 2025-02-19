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

        public User Create(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }

        public User? Delete(int id)
        {
            var user = dbContext.Users.Find(id);
            if (user == null) 
            {
                return null;
            }
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
            return user;
        }

        public List<User> GetAll()
        {
            return dbContext.Users.ToList();
        }

        public User? GetById(int id)
        {
            return dbContext.Users.Find(id);
        }

        public User? Update(int id, User user)
        {
            var existingUser = dbContext.Users.Find(id);
            if (existingUser == null)
            {
                return null;
            }
            existingUser.CreatedDate = user.CreatedDate;
            existingUser.ModifiedDate = user.ModifiedDate;
            existingUser.Email = user.Email;
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.PhoneNumber = user.PhoneNumber;
            existingUser.ModifiedBy = user.ModifiedBy;
            existingUser.CreatedBy = user.CreatedBy;
            existingUser.Password = user.Password;
            dbContext.SaveChanges();
            return existingUser;
        }
    }
}
