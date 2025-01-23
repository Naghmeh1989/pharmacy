using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;

        public BrandsController(PharmacyDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var brands = dbContext.Brands.ToList();
            var brandsDto = mapper.Map<List<BrandDto>>(brands);
            return Ok(brandsDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var brand = dbContext.Brands.Find(id);
            if (brand == null)
            {
                return NotFound();
            }
            var brandDto = mapper.Map<BrandDto>(brand);
            return Ok(brandDto);
        }
    }
}
