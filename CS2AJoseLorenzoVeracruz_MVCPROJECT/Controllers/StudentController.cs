using CS2AJoseLorenzoVeracruz_MVCPROJECT.BusLogic.Model;
using CS2AJoseLorenzoVeracruz_MVCPROJECT.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace CS2AJoseLorenzoVeracruz_MVCPROJECT.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly StudentService _studentService = new StudentService();
        


        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }

        public IActionResult AddNewStudent()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddStudent(tblStudent student)
        {
            try
            {
                bool result = _studentService.Add(student);
                return Json(new { success = result, message = result ? "Student added successfully" : "Failed to add student" });
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding student");
                return Json(new { success = false, message = "An error occured" });
            }
        }


        public IActionResult EditStudent(int id)
        {
            var student = _studentService.getById(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
                                
    





        [HttpGet]
        public IActionResult GetStudentByID(int id)
        {
            try
            {
                var student = _studentService.getById(id);
                return View(student);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editting student");
                return Json(new { success = false, message = "An error occurred" });
            }
        }

        [HttpPost]
        public IActionResult UpdateStudent(tblStudent student)
        {
            try
            {
                var result = _studentService.Update(student);
                return Json(new { success = result, message = result ? "Student updated successfully" : "Failed to update student" });
            } 
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred" });
            }
        }

      









    }

}
