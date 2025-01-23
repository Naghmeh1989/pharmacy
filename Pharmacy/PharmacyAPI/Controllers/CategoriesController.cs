using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public CategoriesController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
