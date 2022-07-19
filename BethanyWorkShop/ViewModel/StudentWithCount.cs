using BethanyWorkShop.Models;

namespace BethanyWorkShop.ViewModel
{
    public class StudentWithCount
    {
        
            public IEnumerable<Student> students { get; set; }
            public int count { get; set; }
        }

    
}
