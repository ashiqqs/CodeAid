using DesignPattern.DI.Models;
using DesignPattern.DI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IPersonService person;
        public StudentController(Func<PersonType, IPersonService> person)
        {
            this.person = person(PersonType.Student);
        }

        [HttpGet, Route("info")]
        public IActionResult GetInfo()
        {
            Student student = new Student();
            student.FirstName = "Ashiq";
            student.DateOfBirth = new DateTime();
            string info = person.GetBasicInfo(student);
            return Ok(info);
        }
    }
}
