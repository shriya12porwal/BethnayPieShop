using BethanyWorkShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanyWorkShop.Controllers
{
    public class TeamAController : Controller
    {
        public ViewResult ListA()
        {
            var students = new List<Student> {

            new Student { FirstName = "Amara", LastName = "Sriram", Age = 21, Gender = "M", TeamName = "A" },
                new Student { FirstName = "Muskan", LastName = "Muskan", Age = 20, Gender = "F", TeamName = "A" },
                new Student { FirstName = "Rahul", LastName = "Yadav", Age = 21, Gender = "M", TeamName = "A" },
                new Student { FirstName = "Shraddha", LastName = "Shraddha", Age = 20, Gender = "F", TeamName = "A" },
                new Student { FirstName = "Aishwarya", LastName = "Verma", Age = 20, Gender = "F", TeamName = "A" }

               
                };
            return View(students);
        }
    }
}
