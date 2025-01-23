using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsTagsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public ProductsTagsController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
