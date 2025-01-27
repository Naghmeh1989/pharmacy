using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;
using PharmacyAPI.Repositories;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsTagsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IProductTagRepository productTagRepository;

        public ProductsTagsController(PharmacyDbContext dbContext,IMapper mapper,IProductTagRepository productTagRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.productTagRepository = productTagRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var productsTags = productTagRepository.GetAll();
            var productsTagsDto = mapper.Map<List<ProductTagDto>>(productsTags);
            return Ok(productsTagsDto);
        }

        
    }
}
