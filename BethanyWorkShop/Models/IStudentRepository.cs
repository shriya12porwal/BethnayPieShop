namespace BethanyWorkShop.Models
{
    public interface IStudentRepository
    {
    IEnumerable<Student> GetAllStudents();
    IEnumerable<Student> GetAllMaleStudents();
    IEnumerable<Student> GetAllFeMaleStudents();
    IEnumerable<Student> GetTeamAStudents();
    IEnumerable<Student> GetTeamBStudents();
    IEnumerable<Student> GetTeamCStudents();
        IEnumerable<Student> GetTeamDStudents();
       
    }
}
