using StudentTask.Entities;

namespace KazimTask.Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll(string groupNo);
    }
}
