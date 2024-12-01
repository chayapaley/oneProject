using lesson3.Models;
using lesson3.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lesson3.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class taskController : ControllerBase
    {
        private readonly ItasksService _taskService;
        private readonly IuserServies _userServies;
        public taskController(ItasksService taskService, IuserServies userServies)
        {
            _taskService = taskService;
            _userServies = userServies;
        }

        [HttpGet]
        public IEnumerable<Tasks> GetTasks()
        {
            return _taskService.GetAllTasks();
        }

        [HttpGet("{id}")]
        public IEnumerable<Tasks> GetTasksbyid(int id)
        {
            return _taskService.GetAllTasksbyid( id);
        }

        [HttpPost]
        public IActionResult createTask([FromBody]Tasks task)
    {
            var user = _userServies.getUserByUserId(task.userId);
            if (user == null)
            {
                return NotFound("User not found");
            }
            return Ok(_taskService.createTask(task));
        }
    }
  }

  

