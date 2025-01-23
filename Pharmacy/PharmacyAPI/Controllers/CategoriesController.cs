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
    public class CategoriesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;

        public CategoriesController(PharmacyDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        { 
            var categories = dbContext.Categories.ToList();
            var categoriesDto = mapper.Map<List<CategoryDto>>(categories);
            return Ok(categoriesDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id) 
        {
            var category = dbContext.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            var categoryDto = mapper.Map<CategoryDto>(category);
            return Ok(categoryDto);
        }
    }
}
