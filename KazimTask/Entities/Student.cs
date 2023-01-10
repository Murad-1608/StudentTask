using StudentTask.Enums;

namespace StudentTask.Entities
{
    public class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public StudentType Type { get; set; }
    }
}
