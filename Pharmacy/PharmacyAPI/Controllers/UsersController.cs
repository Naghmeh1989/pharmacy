using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public UsersController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

    }
}
