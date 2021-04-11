using Microsoft.AspNetCore.Mvc;
using sunriseTEST.Managers.Students;
using sunriseTEST.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sunriseTEST.Controllers
{
    public class StudentController : Controller
    {
        private IStudentManager _manager;
        public StudentController(IStudentManager manager)
        {
            _manager = manager;
        }
        public IActionResult Index()
        {
            var students = _manager.GetAll();
            return View(students);
        }

        [HttpPost]
        public IActionResult DeleteStudent(int studentId)
        {
            _manager.Delete(studentId);
            return RedirectToAction(nameof(Index));
        }
    }
}
