using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public ProductsController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
