using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLProductRepository : IProductRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLProductRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }

        public Product? GetById(int id)
        {
            return dbContext.Products.Find(id);
        }

        public Product Create(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return product;
        }

        public Product? Update(int id,Product product)
        {
            var existingProduct = dbContext.Products.Find(id);
            if (existingProduct == null)
            {
                return null;
            }
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.DiscountedPrice = product.DiscountedPrice;
            existingProduct.CreatedDate = product.CreatedDate;
            existingProduct.CreatedBy = product.CreatedBy;
            existingProduct.ModifiedDate = product.ModifiedDate;
            existingProduct.ModifiedBy = product.ModifiedBy;
            existingProduct.BrandId = product.BrandId;
            existingProduct.CategoryId = product.CategoryId;
            dbContext.SaveChanges();
            return existingProduct;
        }

        public Product? Delete(int id)
        {
            var product = dbContext.Products.Find(id);
            if (product == null)
            {
                return null;
            }
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
            return product;
        }
    }
}
