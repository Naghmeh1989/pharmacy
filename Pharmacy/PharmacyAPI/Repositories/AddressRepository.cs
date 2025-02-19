using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly PharmacyDbContext dbContext;

        public AddressRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Address Create(Address address)
        {
            dbContext.Addresses.Add(address);
            dbContext.SaveChanges();
            return address;
        }

        public Address? Delete(int id)
        {
            var address = dbContext.Addresses.Find(id);
            if (address == null) 
            { 
                return null; 
            }
            dbContext.Addresses.Remove(address);
            dbContext.SaveChanges();
            return address;
        }

        public List<Address> GetAll()
        {
            return dbContext.Addresses.ToList();
        }

        public Address? GetById(int id)
        {
            return dbContext.Addresses.Find(id);
        }

        public Address? Update(int id, Address address)
        {
            var existingAddress = dbContext.Addresses.Find(id);
            if (existingAddress == null)
            {
                return null;
            }
            existingAddress.City = address.City;
            existingAddress.Country = address.Country;
            existingAddress.CreatedBy = address.CreatedBy;
            existingAddress.CreatedDate = address.CreatedDate;
            existingAddress.ModifiedBy = address.ModifiedBy;
            existingAddress.ModifiedDate = address.ModifiedDate;
            existingAddress.FlatNumber = address.FlatNumber;
            existingAddress.MobileNumber = address.MobileNumber;
            existingAddress.HouseNumber = address.HouseNumber;
            existingAddress.StreetName = address.StreetName;    
            existingAddress.PostCode = address.PostCode;
            dbContext.SaveChanges();
            return existingAddress;
        }
    }
}
