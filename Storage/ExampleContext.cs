using sunriseTEST.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sunriseTEST.Storage
{
    public class ExampleContext
    {
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }

        public ExampleContext()
        {
            Students = new List<Student>();
            Groups = new List<Group>();

            /*var group1 = new Group(Guid.NewGuid(), "idb", "itivs");
            var group2 = new Group(Guid.NewGuid(), "idb2", "itivs");

            Students.Add(new Student(Guid.NewGuid(), "vlad", "moiseevvv", group1));
            Students.Add(new Student(Guid.NewGuid(), "vlad1", "moiseevvv2", group2));

            Groups.Add(group1);
            Groups.Add(group2);*/
        }
    }
}
