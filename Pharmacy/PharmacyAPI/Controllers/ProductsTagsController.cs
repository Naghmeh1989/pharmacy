using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsTagsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;

        public ProductsTagsController(PharmacyDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var productsTags = dbContext.ProductsTags.ToList();
            var productsTagsDto = mapper.Map<List<ProductTagDto>>(productsTags);
            return Ok(productsTagsDto);
        }

        
    }
}
