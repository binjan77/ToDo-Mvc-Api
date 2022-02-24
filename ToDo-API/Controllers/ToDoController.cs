using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ToDo_API.Models;
using ToDo_API.Repository;

namespace ToDo_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ILogger<ToDoController> _logger;
        private readonly IConfiguration _configuration;

        public ToDoController(IConfiguration configuration, ILogger<ToDoController> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetToDos()
        {
            ToDoRepository toDoRepository = new ToDoRepository(_configuration);
            return Ok(toDoRepository.GetToDos());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetToDo(int id)
        {
            ToDoRepository toDoRepository = new ToDoRepository(_configuration);
            return Ok(toDoRepository.GetToDo(id));
        }

        [HttpPost]
        public IActionResult Insert(ToDoModel toDoModel)
        {
            ToDoRepository toDoRepository = new ToDoRepository(_configuration);
            return Ok(toDoRepository.Insert(toDoModel));
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult Edit(int id, ToDoModel toDoModel)
        {
            ToDoRepository toDoRepository = new ToDoRepository(_configuration);
            return Ok(toDoRepository.Update(id, toDoModel));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            ToDoRepository toDoRepository = new ToDoRepository(_configuration);
            return Ok(toDoRepository.Delete(id));
        }
    }
}