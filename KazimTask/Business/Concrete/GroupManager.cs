using KazimTask.Business.Abstract;
using KazimTask.InMemory;
using StudentTask.Entities;

namespace KazimTask.Business.Concrete
{
    public class GroupManager : IGroupService
    {
        List<Group> _groups = Lists.Groups;
        public void Add(Group group)
        {
            List<Group> groups = _groups.Where(x => x.No == group.No).ToList();

            if (groups.Count == 0)
            {
                if (group.IsOnline == true)
                {
                    group.Limit = 15;
                }
                else
                {
                    group.Limit = 10;
                }
                _groups.Add(group);
            }
            else
            {
                Console.WriteLine("Bu qrup nomresi movcuddur");
                Console.Write("Yeniden qrup nomresi yazin : ");
                string groupNo = Console.ReadLine();
                group.No = groupNo;
                Add(group);
            }
        }

        public List<Group> GetAll()
        {
            return _groups;
        }

        public void Update(string groupNo, string NewNo)
        {
            Group _group = _groups.FirstOrDefault(x => x.No == groupNo);

            if (_group == null)
            {
                Console.WriteLine("Bele nomrede qrup yoxdur");
            }
            else
            {
                Group group1 = _groups.FirstOrDefault(x => x.No == NewNo);

                if (group1 == null)
                {
                    _groups.FirstOrDefault(x => x.No == groupNo).No = NewNo;
                }
                else
                {
                    Console.WriteLine("Bu qrup nomresi movcuddur");
                    Console.Write("Yeniden qrup nomresi yazin : ");
                    string NewgroupNo = Console.ReadLine();
                    NewNo = NewgroupNo;
                    Update(groupNo, NewNo);
                }
            }
        }
    }
}
