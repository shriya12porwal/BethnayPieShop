using Microsoft.AspNetCore.Mvc;
using BethanyWorkShop.Models;
namespace BethanyWorkShop.Controllers
{
    public class TeamCController : Controller
    {
        public ViewResult ListC()
        {
            var students = new List<Student> {

            new Student{FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
                new Student{FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
                new Student{FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
                new Student{FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
                new Student{FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" }


                };
            return View(students);
        }
    }
}
