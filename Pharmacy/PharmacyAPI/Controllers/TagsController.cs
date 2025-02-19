using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;
using PharmacyAPI.Repositories;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly ITagRepository tagRepository;

        public TagsController(PharmacyDbContext dbContext,IMapper mapper,ITagRepository tagRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.tagRepository = tagRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var tags = tagRepository.GetAll();
            var tagsDto = mapper.Map<List<TagDto>>(tags);
            return Ok(tagsDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var tag = dbContext.Tags.Find(id);
            if (tag == null)
            {
                return NotFound();
            }
            var tagDto = mapper.Map<TagDto>(tag);
            return Ok(tagDto);
        }

        [HttpPost]
        public IActionResult Create([FromBody] AddTagDto addTagDto)
        { 
            var tag = mapper.Map<Tag>(addTagDto);
            tagRepository.Create(tag);
            var tagDto = mapper.Map<TagDto>(tag);
            return Ok(tagDto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id) 
        { 
            var tag = tagRepository.Delete(id);
            if(tag == null)
            {  
                return NotFound(); 
            }
            return Ok(mapper.Map<TagDto>(tag));
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateTagDto updateTagDto)
        {
            var tag = mapper.Map<Tag>(updateTagDto);
            tag = tagRepository.Update(id, tag);
            if (tag == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<TagDto>(tag));
        }
    }
}
