using Microsoft.AspNetCore.Mvc;
using My_Portfolio2.Models;
using My_Portfolio2.ViewModels;

namespace My_Portfolio2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            About_me me = new About_me
            {
                Name = "Mohammed Rehab",
                Age = 21,
                Field= "ASP.NET Core development",
                Studies= "Fundamentals of Programming, Data Structures & Algorithms, Object-Oriented Programming (OOP), Database Management, Software Engineering, Computer Networking, Operating Systems, Computer Graphics, Linear Algebra, and Probability Theory & Statistics",
                Specialization = { "Student", "Backend Developer" },
                University = "the Computer and Automatic Control Department, Faculty of Engineering, Tanta University",
                Gender = "Male",
                Address = "Tanta",
                Training = "the Egypt Digital Cubs Initiative",
                Skills = { "ASP.NET Core", "MVC architecture", "C#", "Python", "MySQL" }
            };
            return View("Index", me);

        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Skills()
        {
            ViewData["Software Development:"] = new List<String>
            {
                "Object-Oriented Programming (OOP)",",","Data Structures and Algorithms"
            };
            ViewData["Databases:"] = "Design Patterns, DBMS, System Design and Microsoft SQL Server";
            ViewData["Tools & Frameworks:"] = "Git and GitHub";
            ViewBag.Languages = "C#, C++ and Python";
            ViewBag.back = "Database Design, SQL, C#, OOP, LINQ, EF Core, MVC";
            ViewBag.front = "HTML, CSS";

            return View();
        }
        public IActionResult ContactMe()
        {
            return View();
        }
        public IActionResult Projects()
        {
            Project proj_01 = new Project
            {
                Name = "Project_GG Game(With my university team)",
                description = { "• Developed a 2D platformer game using Python and OpenGL, implementing custom graphics rendering.",
                    "• Designed intuitive levels and engaging game mechanics, emphasizing user experience and smooth gameplay.",
                    "• Strengthened game development and programming skills through practical work in graphics and game design principles."},
            };
            ProjectViewModel Proj01VM = new ProjectViewModel
            {
                project= proj_01,
            };
            return View(Proj01VM);
        }
    }
}
