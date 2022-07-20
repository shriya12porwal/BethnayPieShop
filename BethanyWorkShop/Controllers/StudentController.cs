using Microsoft.AspNetCore.Mvc;
using BethanyWorkShop.ViewModel;
using BethanyWorkShop.Models;
namespace BethanyWorkShop.Controllers
{
    public class StudentController : Controller
    {
        /* public ViewResult Student() //Defalut syantax
         {
             return View();
         }*/
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        public ViewResult List()
        {
            var students = _studentRepository.GetAllStudents();

            StudentWithCount studentsWithCount = new StudentWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();
            ViewBag.List = students.Count();

            return View(studentsWithCount);

        }
        public ViewResult ListMaleStudent()
        {
            var students = _studentRepository.GetAllMaleStudents();
            StudentWithCount studentsWithCount = new StudentWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();
            ViewBag.List = students.Count();
            return View(studentsWithCount);

        }
        public ViewResult ListFeMaleStudent()
        {
            var students = _studentRepository.GetAllFeMaleStudents();
            StudentWithCount studentsWithCount = new StudentWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();
            ViewBag.List = students.Count();

            return View(studentsWithCount);

        }
        public ViewResult ListTeamAStudent()
        {
            var students = _studentRepository.GetTeamAStudents();

            StudentWithCount studentsWithCount = new StudentWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();
            ViewBag.List = students.Count();

            return View(studentsWithCount);

            /*   ViewBag.ListA = students.Count();//Traditional Way

               return View(students);*/
        }
        public ViewResult ListTeamBStudent()
        {
            var students = _studentRepository.GetTeamBStudents();

            StudentWithCount studentsWithCount = new StudentWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();
            ViewBag.List = students.Count();

            return View(studentsWithCount);
        }
        public ViewResult ListTeamCStudent()
        {
            var students = _studentRepository.GetTeamCStudents();

            StudentWithCount studentsWithCount = new StudentWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();
            ViewBag.List = students.Count();

            return View(studentsWithCount);
        }
        public ViewResult ListTeamDStudent()
        {
            var students = _studentRepository.GetTeamDStudents();

            StudentWithCount studentsWithCount = new StudentWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();
            ViewBag.List = students.Count();

            return View(studentsWithCount);
        }
        public ViewResult GetStudentsStartingS()
        {
            var students = _studentRepository.GetStudentsStartingS();

            StudentWithCount studentsWithCount = new StudentWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();
            ViewBag.List = students.Count();

            return View(studentsWithCount);
        }
        public ViewResult GetStudentCount()
        {
            var students = _studentRepository.GetStudentCount();
            return View(students);
        }


        public ViewResult Details(int id)
        {
            var students = _studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            return View(students);

        }
        public ViewResult Edit(int id)
        {
            var students = _studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            return View(students);

        }
        public ViewResult Create()
        {
            
            return View();

        }
        public ViewResult Remove(int id)
        {
            var student = _studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            return View(student);

        }
        //Controller -> Repository ->appdbContext ->dtabase
        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            _studentRepository.CreateStudent(student);
            return RedirectToAction("List");
        }


        public IActionResult RemoveStudent(Student student)
        {
           // var student = _studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            _studentRepository.RemoveStudent(student);
            return RedirectToAction("List");
        }
















        /*public ViewResult List() 
        {
            //Action Method -> list
            var students = new List<Student> {
                //Student Data is ready.
                new Student{FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
                new Student{FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
                new Student{FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
                new Student{FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
                new Student{FirstName="Aishwarya",LastName="Verma",Age=20, Gender="F", TeamName="A" },

                new Student{FirstName="Shreya",LastName="",Age=20, Gender="F", TeamName="B" },
                new Student{FirstName="Nandhita",LastName="",Age=20, Gender="F", TeamName="B" },
                new Student{FirstName="Shashwat",LastName="",Age=20, Gender="M", TeamName="B" },
                new Student{FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
                new Student{FirstName="Shriya",LastName="",Age=20, Gender="F", TeamName="B" },


                new Student{FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
                new Student{FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
                new Student{FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
                new Student{FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
                new Student{FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },

                new Student{FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
                new Student{FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
                new Student{FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
                new Student{FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
                new Student { FirstName = "Tisha", LastName = "Varshney", Age = 20, Gender = "F", TeamName = "D" },
                new Student { FirstName = "Aman", LastName = "Asati", Age = 21, Gender = "M", TeamName = "D" }
                };
            return View(students);


    }*/
    }
}
