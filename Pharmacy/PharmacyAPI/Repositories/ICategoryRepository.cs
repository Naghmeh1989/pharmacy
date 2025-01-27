using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
    }
}
