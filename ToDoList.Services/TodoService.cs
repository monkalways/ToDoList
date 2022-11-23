using ToDoList.Services.Models;

namespace ToDoList.Services
{
    public class TodoService : ITodoService
    {
        public List<Todo> GetTodos()
        {
            return new List<Todo>
            {
                new Todo { Id = 1, Name = "Clean floor", IsComplete = false, DueDate = DateTime.Today },
                new Todo { Id = 2, Name = "Walk the dog", IsComplete = false, DueDate = DateTime.Today.AddDays(1) },
                new Todo { Id = 3, Name = "Walk the dog Again", IsComplete = false, DueDate = DateTime.Today.AddDays(1) }
            };
        }
    }
}