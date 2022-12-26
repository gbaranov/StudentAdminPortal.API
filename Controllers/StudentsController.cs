using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly iStudentRepository studentRepository;
        public StudentsController(iStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            Mapper = mapper;
        }

        public IMapper Mapper { get; }

        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetAllStudents()
        {
            var students = studentRepository.GetStudents();

            return Ok(Mapper.Map<List<Student>>(students));

            //var domainModelsStudents = new List<Student>();

            //foreach (var student in students)
            //{
            //    domainModelsStudents.Add(new Student()
            //    {
            //        Id = student.Id,
            //        FirstName = student.FirstName,
            //        LastName = student.LastName,
            //        DateOfBirth = student.DateOfBirth,
            //        Email = student.Email,
            //        Mobile = student.Mobile,
            //        ProfileImageUrl = student.ProfileImageUrl,
            //        GenderId = student.GenderId,
            //        Address = new Address()
            //        {
            //            Id = student.Address.Id,
            //            PhysicalAddress = student.Address.PhysicalAddress,
            //            PostalAddress = student.Address.PostalAddress,
            //        },
            //        Gender = new Gender()
            //        {
            //            Id = student.GenderId,
            //            Description = student.Gender.Description,
            //        }
            //    });
            //}
        }

    }
}
