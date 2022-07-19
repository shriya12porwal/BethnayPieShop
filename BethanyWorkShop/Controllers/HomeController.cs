using BethanyWorkShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BethanyWorkShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository studentRepository;

        public HomeController(ILogger<HomeController> logger , IStudentRepository studentRepository)
        {
            _logger = logger;
            this.studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            var studentsCount = studentRepository.GetStudentCount();
            return View(studentsCount);
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