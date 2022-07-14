namespace BethanyWorkShop.Models
{
    public class StudentRepository : IStudentRepository
    {
        public IEnumerable<Student> GetAllStudents()
        {
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
            return students;
        }
        public IEnumerable<Student> GetAllMaleStudents()
        {
               return GetAllStudents().Where(student => student.Gender == "M");
        }
        public IEnumerable<Student> GetAllFeMaleStudents()
        {
            return GetAllStudents().Where(student => student.Gender == "F");
        }
        public IEnumerable<Student> GetTeamAStudents()
        {
            return GetAllStudents().Where(student => student.TeamName == "A");
        }
        public IEnumerable<Student> GetTeamBStudents()
        {
            return GetAllStudents().Where(student => student.TeamName == "B");
        }
        public IEnumerable<Student> GetTeamCStudents()
        {
            return GetAllStudents().Where(student => student.TeamName == "C");
        }
        public IEnumerable<Student> GetTeamDStudents()
        {
            return GetAllStudents().Where(student => student.TeamName == "D");
        }

        
    }
}
