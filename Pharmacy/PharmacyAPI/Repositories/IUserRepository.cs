using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
