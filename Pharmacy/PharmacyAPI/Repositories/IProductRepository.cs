using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll(string? filterOn = null, string? filterQuery = null,
            string? sortBy = null, bool isAscending = true);
        Product? GetById(int id);
        Product Create(Product product);
        Product? Update(int id,Product product);
        Product? Delete(int id);
    }
}
