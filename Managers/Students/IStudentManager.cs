using sunriseTEST.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sunriseTEST.Managers.Students
{
    public interface IStudentManager
    {
        ICollection<Student> GetAll();
        ICollection<Student> GetStudentByGroup(int groupId);
        void Delete(int id);
    }
}
