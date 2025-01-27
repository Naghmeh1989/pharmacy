using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product? GetById(int id);
        Product Create(Product product);
        Product? Update(int id,Product product);
        Product? Delete(int id);
    }
}
