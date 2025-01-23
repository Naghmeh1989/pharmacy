using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public TagsController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
