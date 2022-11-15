using ToDoList.Services.Models;

namespace ToDoList.Services
{
    public interface ITodoService
    {
        List<Todo> GetTodos();
    }
}
