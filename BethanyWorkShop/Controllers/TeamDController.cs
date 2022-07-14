using Microsoft.AspNetCore.Mvc;
using BethanyWorkShop.Models;
namespace BethanyWorkShop.Controllers
{
    public class TeamDController : Controller
    {
        public ViewResult ListD()
        {
            var students = new List<Student> {

            new Student{FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
                new Student{FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
                new Student{FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
                new Student{FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
                new Student { FirstName = "Tisha", LastName = "Varshney", Age = 20, Gender = "F", TeamName = "D" },
                new Student { FirstName = "Aman", LastName = "Asati", Age = 21, Gender = "M", TeamName = "D" }

                };
            return View(students);
        }
    }
}
