using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category? GetById(int id);
        Category Create(Category category);
        Category? Delete(int id);
        Category? Update(int id,Category category);
    }
}
