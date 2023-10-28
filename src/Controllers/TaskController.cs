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
        private readonly TaskContext _context;

        public TarefaController(TaskContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateTask(Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetTaskById), new { id = task.Id }, task);
        }

        [HttpGet("ObterTodos")]
        public IActionResult GetAllTasks()
        {
            var tasks = _context.Tasks.ToList();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public IActionResult GetTaskById(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task == null)
            {
                return NotFound("Entity not found");
            }
            return Ok(task);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult FindByTitle(string titulo)
        {
            var task = _context.Tasks.Where(x => x.Titulo.Contains(titulo));
            if (task == null)
            {
                return NotFound("Entity not found");
            }
            return Ok(task);
        }

        [HttpGet("ObterPorData")]
        public IActionResult FindByDate(DateTime date)
        {
            var task = _context.Tasks.Where(x => x.Data.Date == date.Date);
            if (task == null)
            {
                return NotFound("Entity not found");
            }
            return Ok(task);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult FindByStatus(TaskStatus status)
        {
            var task = _context.Tasks.Where(x => x.Status.Equals(status));
            if (task == null)
            {
                return NotFound("Entity not found");
            }
            return Ok(task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, Task task)
        {
            var existingTask = _context.Tasks.Find(id);
            if (existingTask == null)
            {
                return NotFound("Entity not found");
            }
            if (
                task.Data == null
                || task.Titulo == null
                || task.Descricao == null
                || task.Status.Equals(null)
            )
            {
                return BadRequest("Missing task fields");
            }
            existingTask.Data = task.Data;
            existingTask.Descricao = task.Descricao;
            existingTask.Titulo = task.Titulo;
            existingTask.Status = task.Status;

            _context.Tasks.Update(existingTask);
            _context.SaveChanges();

            return Ok(existingTask);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var existingTask = _context.Tasks.Find(id);
            if (existingTask == null)
            {
                return NotFound("Entity not found");
            }
            _context.Remove(existingTask);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
