using Microsoft.AspNetCore.Mvc;
using Organizer.Contexts;
using Task = Organizer.Models.Task;
using TaskStatus = Organizer.Models.TaskStatus;

namespace Organizer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("Hello, World!");
        }
    }
}
