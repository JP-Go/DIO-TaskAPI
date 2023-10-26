using Microsoft.AspNetCore.Mvc;

namespace Organizer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("Hello, World!");
        }
    }
}
