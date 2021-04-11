using sunriseTEST.Storage;
using sunriseTEST.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sunriseTEST.Managers.Students
{
    public class StudentManager: IStudentManager
    {
        private UniversityContext _context;
        public StudentManager(UniversityContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(st => st.Id == id);
            if (student != null)
                _context.Students.Remove(student);
        }

        public ICollection<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public ICollection<Student> GetStudentByGroup(int groupId)
        {
            return _context.Students.Where(st => st.Group.Id == groupId).ToList();
        }
    }
}
