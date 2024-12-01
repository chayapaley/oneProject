using lesson3.Models;
using lesson3.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lesson3.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IuserServies _userServies;
        public UserController(IuserServies userServies)
        {
            _userServies = userServies;
        }

        [HttpGet("{id}")]
       
        public IEnumerable<Tasks> GetTasksbyUserId(int id)
        {
            return  _userServies.GetAllTasksbyUserId(id);
        }
}

    }

