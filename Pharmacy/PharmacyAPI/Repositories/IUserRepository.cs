using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User? GetById(int id);
        User Create(User user);
        User? Delete(int id);
        User? Update(int id,User user);
    }
}
