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
                new Flashcard { Id = 3, Question = "What is the primary purpose of Entity Framework Core?", Answer = "C. To map objects in code to relational database data" },
                new Flashcard { Id = 4, Question = "Which EF Core component is primarily responsible for communicating with the database?", Answer = "A. DbContext"},
                new Flashcard { Id = 5, Question = "What does the following command primarily do? dotnet ef dbcontext scaffold...", Answer = "C. Generates EF Core models and a DbContext from an existing database"},
                new Flashcard { Id = 6, Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?", Answer = "B. appsettings.json" },

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
