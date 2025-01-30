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
    public class ProductsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IProductRepository productReppository;
        private readonly ILogger<ProductsController> logger;

        public ProductsController(PharmacyDbContext dbContext,IMapper mapper,IProductRepository productReppository,
            ILogger<ProductsController> logger)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.productReppository = productReppository;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery,
            [FromQuery] string? sortBy, [FromQuery] bool isAscending)
        {
            try
            {
                var products = productReppository.GetAll(filterOn,filterQuery,sortBy,isAscending);
                var productsDto = mapper.Map<List<ProductDto>>(products);
                return Ok(productsDto);
            }
            catch (Exception ex) 
            { 
                logger.LogError(ex,ex.Message);
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            try
            {
                var product = productReppository.GetById(id);
                if (product == null)
                {
                    return NotFound();
                }
                var productDto = mapper.Map<ProductDto>(product);
                return Ok(productDto);
            }
            catch (Exception ex) 
            {
                logger.LogError(ex, ex.Message);
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult create([FromBody] AddProductDto addProductDto)
        {
            try
            {
                var product = mapper.Map<Product>(addProductDto);
                productReppository.Create(product);
                var productDto = mapper.Map<ProductDto>(product);
                return Ok(productDto);
            }
            catch (Exception ex) 
            {
                logger.LogError(ex, ex.Message);
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateProductDto updateProductDto)
        {
            try
            {
                var product = mapper.Map<Product>(updateProductDto);
                product = productReppository.Update(id, product);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(mapper.Map<ProductDto>(product));
            }
            catch (Exception ex) 
            {
                logger.LogError(ex, ex.Message);
                return BadRequest();
            }
        }


        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                var product = productReppository.Delete(id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(mapper.Map<ProductDto>(product));
            }
            catch (Exception ex) 
            {
                logger.LogError(ex, ex.Message);
                return BadRequest();
            }
        }
    }
}
