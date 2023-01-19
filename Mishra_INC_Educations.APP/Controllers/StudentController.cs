using Microsoft.AspNetCore.Mvc;
using Mishra_INC_Educations.APP.Models;
using Mishra_INC_Educations.Server.Abstractions;
using Mishra_INC_Educations.Shared.Request.Students;

namespace Mishra_INC_Educations.APP.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public IActionResult CreateStudent()
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            return View(studentViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(StudentViewModel studentViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(studentViewModel);
            }
            CreateStudentsCommand createStudentsCommand = new();
            createStudentsCommand.FirstName= studentViewModel.FirstName;
            createStudentsCommand.LastName=studentViewModel.LastName;
            createStudentsCommand.FatherName= studentViewModel.FatherName;
            createStudentsCommand.MotherName= studentViewModel.MotherName;
            createStudentsCommand.GuardianName= studentViewModel.GuardianName;
            createStudentsCommand.ClassSections = studentViewModel.ClassSections.Value;
            createStudentsCommand.ClassStandred = studentViewModel.ClassStandred.Value;
            createStudentsCommand.Address = studentViewModel.Address;
            createStudentsCommand.PinCode = studentViewModel.PinCode.Value;
            createStudentsCommand.FatherEmail= studentViewModel.FatherEmail;
            createStudentsCommand.FatherMobileNo = studentViewModel.FatherMobileNo.Value;
            var response = await studentRepository.AddStudent(createStudentsCommand);
            if (response.Status)
            {
                ViewBag.SuccessMessage = response.SuccessMessage;
            }
            else
            {
                ViewBag.ErrorMessage = response.ErrorMessage;
            }
            return View(studentViewModel);
        }
    }
}
