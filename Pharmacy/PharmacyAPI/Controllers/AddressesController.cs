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
    public class AddressesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;

        public AddressesController(PharmacyDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var addresses = dbContext.Addresses.ToList();
            var addressesDto = mapper.Map<List<AddressDto>>(addresses);
            return Ok(addressesDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        { 
            var address = dbContext.Addresses.Find(id);
            if (address == null)
            {
                return NotFound();
            }
            var addressDto = mapper.Map<AddressDto>(address);
            return Ok(addressDto);
        }
    }
}
