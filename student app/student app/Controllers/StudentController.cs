using Microsoft.AspNetCore.Mvc;
using student_app.DAL;

namespace student_app.Controllers
{
    
    public class StudentController : Controller   
    {
        private readonly StudentDbContext _studentDbContext;
        public StudentController(StudentDBcontext studentDBcontext)
        {
            _studentDbContext = studentDBcontext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var students = _studentDbContext.Student.ToList();
            List<StudentViewModel>studentlist=new List<StudentViewModel>();

            foreach (var student in students)
            {
                studentlist.Add(new StudentViewModel {Id=student.id , FirstName=student.Firstname ,LastName=student.LastName , Email=student.Email });
            }

            return View(students);
        }
    }
}
