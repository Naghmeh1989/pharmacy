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
    public class UsersController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        public UsersController(PharmacyDbContext dbContext,IMapper mapper,IUserRepository userRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = userRepository.GetAll();
            var usersDto = mapper.Map<List<UserDto>>(users);
            return Ok(usersDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var user = dbContext.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            var userDto = mapper.Map<UserDto>(user);
            return Ok(userDto);
        }

        [HttpPost]
        public IActionResult Create([FromBody] AddUserDto addUserDto) 
        {
            var user = mapper.Map<User>(addUserDto);
            userRepository.Create(user);
            var userDto = mapper.Map<UserDto>(user);
            return Ok(userDto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id) 
        {
            var user = userRepository.Delete(id);
            if(user == null)
            {  
                return NotFound(); 
            }
            return Ok(mapper.Map<UserDto>(user));
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateUserDto updateUserDto)
        {
            var user = mapper.Map<User>(updateUserDto);
            user = userRepository.Update(id, user);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<UserDto>(user));
        }

    }
}
