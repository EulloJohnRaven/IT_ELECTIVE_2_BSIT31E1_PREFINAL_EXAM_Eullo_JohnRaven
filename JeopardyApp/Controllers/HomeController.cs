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
                new Flashcard { Id = 7, Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?", Answer = "B. One-to-Many"},
                new Flashcard { Id = 8, Question = "In the following example, what is SectionId? public int SectionId { get; set; }", Answer = "B. Foreign key referencing Section" },
                new Flashcard { Id = 9, Question = "What is the purpose of a navigation property such as public Section Section { get; set; }?", Answer = "B. It represents a relationship to another entity" },
                new Flashcard { Id = 10, Question = "What does .Include() generally allow EF Core to do?", Answer = "B. Load related Section data together with Students" },
                new Flashcard { Id = 11, Question = "Why might a ViewModel be used when displaying Student and Section information?",Answer = "B. To combine or shape the data specifically needed by the view"},
                new Flashcard { Id = 12, Question = "What is the main benefit of Include(s => s.Section)?", Answer = "A. It loads the related Section navigation property" },
                new Flashcard { Id = 13, Question = "Which type of validation occurs in the browser before a request is sent to the server?", Answer = "B. Client-side validation" },
                new Flashcard { Id = 14, Question = "Why is server-side validation still necessary if client-side validation exists?", Answer = "A. Client-side validation can be bypassed"},
                new Flashcard { Id = 15, Question = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?", Answer = "B. Student Number should be unique" },
                new Flashcard { Id = 16, Question = "Which is the best reason for having a database-level unique constraint on StudentNumber?", Answer = "A. It protects data integrity even if application-level validation is bypassed"},
                new Flashcard { Id = 17, Question = "What is the purpose of a try...catch block in a controller?", Answer = "B. To catch and handle exceptions that may occur during execution" },
                new Flashcard { Id = 18, Question = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?", Answer = "B. UseExceptionHandler()" },

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
