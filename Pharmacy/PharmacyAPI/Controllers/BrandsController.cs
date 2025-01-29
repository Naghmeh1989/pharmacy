using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;
using PharmacyAPI.Repositories;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IBrandRepository brandRepository;

        public BrandsController(PharmacyDbContext dbContext,IMapper mapper,IBrandRepository brandRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.brandRepository = brandRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var brands = brandRepository.GetAll();
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
