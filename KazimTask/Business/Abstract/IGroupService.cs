using StudentTask.Entities;

namespace KazimTask.Business.Abstract
{
    public interface IGroupService
    {
        void Add(Group group);
        List<Group> GetAll();
        void Update(string groupNo, string NewNo);
    }
}
