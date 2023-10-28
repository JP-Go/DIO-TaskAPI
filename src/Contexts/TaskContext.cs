using Microsoft.EntityFrameworkCore;
using Task = Organizer.Models.Task;

namespace Organizer.Contexts
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options) { }

        public DbSet<Task> Tasks { get; set; }
    }
}
