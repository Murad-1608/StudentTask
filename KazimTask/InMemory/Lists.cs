using StudentTask.Entities;
using StudentTask.Enums;

namespace KazimTask.InMemory
{
    public static class Lists
    {
        public static List<Group> Groups = new List<Group>()
        {
            new Group() { No="2560a", Category=Category.Programming,IsOnline=true,Limit=15,Students=14 }
        };

    }
}
