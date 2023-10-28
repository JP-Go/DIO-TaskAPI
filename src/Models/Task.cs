namespace Organizer.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public TaskStatus Status { get; set; }
    }
}
