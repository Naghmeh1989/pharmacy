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

        public ProductsController(PharmacyDbContext dbContext,IMapper mapper,IProductRepository productReppository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.productReppository = productReppository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = productReppository.GetAll();
            var productsDto = mapper.Map<List<ProductDto>>(products);
            return Ok(productsDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var product = productReppository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            var productDto = mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }

        [HttpPost]
        public IActionResult create([FromBody] AddProductDto addProductDto)
        { 
            var product = mapper.Map<Product>(addProductDto);
            productReppository.Create(product);
            var productDto = mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateProductDto updateProductDto)
        {
            var product = mapper.Map<Product>(updateProductDto);
            product = productReppository.Update(id, product);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<ProductDto>(product));
        }


        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        { 
            var product = productReppository.Delete(id);
            if(product == null)
            {  
                return NotFound(); 
            }
            return Ok(mapper.Map<ProductDto>(product));
        }
    }
}
