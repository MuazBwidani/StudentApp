using Microsoft.AspNetCore.Mvc;
using student_app.Models;
using System.Diagnostics;

namespace student_app.Controllers
{
    public class StudentDbContext : Controller
    {
        private readonly ILogger<StudentDbContext> _logger;

        public StudentDbContext(ILogger<StudentDbContext> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}