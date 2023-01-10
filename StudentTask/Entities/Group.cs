using StudentTask.Enums;

namespace StudentTask.Entities
{
    public class Group
    {
        public string No { get; set; }
        public Category Category { get; set; }
        public bool IsOnline { get; set; }
        public byte Limit { get; set; }
        public List<Student> Students { get; set; }
    }
}
