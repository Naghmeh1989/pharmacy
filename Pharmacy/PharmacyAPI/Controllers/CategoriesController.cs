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
    public class CategoriesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(PharmacyDbContext dbContext,IMapper mapper,ICategoryRepository categoryRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        { 
            var categories = categoryRepository.GetAll();
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

        [HttpPost]
        public IActionResult Create([FromBody] AddCategoryDto addCategoryDto) 
        { 
            var category = mapper.Map<Category>(addCategoryDto);
            categoryRepository.Create(category);
            var categoryDto = mapper.Map<CategoryDto>(category);
            return Ok(categoryDto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id) 
        {
            var category = categoryRepository.Delete(id);
            if (category == null) 
            { 
                return NotFound();
            }
            return Ok(mapper.Map<CategoryDto>(category));
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateCategoryDto updateCategoryDto)
        {
            var category = mapper.Map<Category>(updateCategoryDto);
            category = categoryRepository.Update(id, category);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<CategoryDto>(category));
        }
    }
}
