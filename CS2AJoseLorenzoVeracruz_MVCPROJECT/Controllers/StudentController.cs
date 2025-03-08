using CS2AJoseLorenzoVeracruz_MVCPROJECT.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace CS2AJoseLorenzoVeracruz_MVCPROJECT.Controllers
{
    public class StudentController : Controller
    {

        private readonly StudentService _studentService = new StudentService();
        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }
    }
}
