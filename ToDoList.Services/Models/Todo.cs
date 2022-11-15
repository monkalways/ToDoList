namespace ToDoList.Services.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public bool IsComplete { get; set; }
        public DateTime DueDate { get; set; }
    }
}
