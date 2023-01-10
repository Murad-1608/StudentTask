using KazimTask.Business.Abstract;
using KazimTask.InMemory;
using StudentTask.Entities;

namespace KazimTask.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        List<Student> students = new List<Student>();
        public List<Student> GetAll(string groupNo)
        {
            return students.Where(x => x.GroupNo == groupNo).ToList();
        }
    }
}
