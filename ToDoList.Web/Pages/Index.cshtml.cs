using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using ToDoList.Services;
using ToDoList.Services.Models;

namespace ToDoList.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITodoService _todoService;
        public List<Todo> Todos { get; set; } = new List<Todo>();
        public string HostName { get; set; }
        public string IpAddress { get; set; }
        public string NodeName { get; set; }
        public string Version { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ITodoService todoService)
        {
            _logger = logger;
            _todoService = todoService;

            HostName = Dns.GetHostName();
            IpAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0]?.ToString() ?? "N/A";
            NodeName = Environment.GetEnvironmentVariable("NODE_NAME") ?? "N/A";
            Version = Environment.GetEnvironmentVariable("VERSION_NUMBER") ?? "N/A";
        }

        public void OnGet()
        {
            Todos = _todoService.GetTodos();
        }
    }
}