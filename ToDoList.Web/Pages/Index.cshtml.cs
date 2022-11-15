using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Services;
using ToDoList.Services.Models;

namespace ToDoList.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITodoService _todoService;
        public List<Todo> Todos { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ITodoService todoService)
        {
            _logger = logger;
            _todoService = todoService;
        }

        public void OnGet()
        {
            Todos = _todoService.GetTodos();
        }
    }
}