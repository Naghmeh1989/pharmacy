using Microsoft.EntityFrameworkCore;
using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly PharmacyDbContext dbContext;

        public ProductRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Product> GetAll(string? filterOn = null, string? filterQuery = null,
            string? sortBy = null, bool isAscending = true)
        {
            var products = dbContext.Products.Include(x=>x.Category).Include(x=>x.Brand).AsQueryable();
            if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                if (filterOn.Equals("Category", StringComparison.OrdinalIgnoreCase))
                {
                   products = products.Where(x => x.Category.Name.Contains(filterQuery));
                }
                else if (filterOn.Equals("Price", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.Where(x => x.Price.Contains(filterQuery));
                }
                else if (filterOn.Equals("Brand", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.Where(x => x.Brand.Name.Contains(filterQuery));
                }
            }
            if (string.IsNullOrWhiteSpace(sortBy) == false)
            {
                if (sortBy.Equals("Price", StringComparison.OrdinalIgnoreCase))
                {
                    products = isAscending ? products.OrderBy(x => x.Price) : products.OrderByDescending(x => x.Price);
                }
                else if (sortBy.Equals("CreatedDate", StringComparison.OrdinalIgnoreCase))
                {
                    products = isAscending ? products.OrderBy(x => x.CreatedDate) : products.OrderByDescending(x => x.CreatedDate);
                }

            }
            return products.ToList();
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
