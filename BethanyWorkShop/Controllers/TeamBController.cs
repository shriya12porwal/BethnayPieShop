using Microsoft.AspNetCore.Mvc;
using BethanyWorkShop.Models;
namespace BethanyWorkShop.Controllers
{
    public class TeamBController : Controller
    {
        public ViewResult ListB()
        {
            var students = new List<Student> {

                new Student{FirstName="Shreya",LastName="",Age=20, Gender="F", TeamName="B" },
                new Student{FirstName="Nandhita",LastName="",Age=20, Gender="F", TeamName="B" },
                new Student{FirstName="Shashwat",LastName="",Age=20, Gender="M", TeamName="B" },
                new Student{FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
                new Student{FirstName="Shriya",LastName="",Age=20, Gender="F", TeamName="B" }
                };

       
            return View(students);
        }
    }
}
