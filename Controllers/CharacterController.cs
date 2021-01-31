using System.Collections.Generic;
using System.Linq;
using DotNetCoreApiDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id = 1,Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get(){
            return Ok(characters);
        }


        [HttpGet("{id}")]
        public IActionResult GetSingle(int id){
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}