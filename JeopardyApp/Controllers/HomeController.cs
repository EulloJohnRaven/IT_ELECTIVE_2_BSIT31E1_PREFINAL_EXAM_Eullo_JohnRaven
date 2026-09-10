using JeopardyApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JeopardyApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var flashcards = new List<Flashcard>
            {
                new Flashcard { Id = 1, Question = "What is the main problem solved by using a database instead of an in-memory collection?", Answer = "C. It allows data to persist after the application stops"},
                new Flashcard { Id = 2, Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?", Answer = "B. Database-First" },

            };

            return View(flashcards);
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
