using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLBrandRepository : IBrandRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLBrandRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Brand Create(Brand brand)
        {
            dbContext.Brands.Add(brand);
            dbContext.SaveChanges();
            return brand;   
        }

        public Brand? Delete(int id)
        {
            var brand = dbContext.Brands.Find(id);
            if (brand == null)
            {
                return null;
            }
            dbContext.Brands.Remove(brand);
            dbContext.SaveChanges();
            return brand;
        }

        public Brand? FindById(int id)
        {
            return dbContext.Brands.Find(id);
        }

        public List<Brand> GetAll()
        {
            return dbContext.Brands.ToList();
        }

        public Brand? Update(int id, Brand brand)
        {
            var existingBrand = dbContext.Brands.Find(id);
            if (existingBrand == null)
            {
                return null;
            }
            existingBrand.CreateDate = brand.CreateDate;
            existingBrand.CreatedBy = brand.CreatedBy;
            existingBrand.ModifiedDate = brand.ModifiedDate;
            existingBrand.ModifiedBy = brand.ModifiedBy;
            existingBrand.Name = brand.Name;
            dbContext.SaveChanges();
            return existingBrand;
        }
    }
}
