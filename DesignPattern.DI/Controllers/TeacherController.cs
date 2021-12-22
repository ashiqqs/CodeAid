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
    public class TeacherController : ControllerBase
    {
        private IPersonService person;
        public TeacherController(Func<PersonType, IPersonService> person)
        {
            this.person = person(PersonType.Teacher);
        }

        [HttpGet, Route("info")]
        public IActionResult GetInfo()
        {
            Teacher teacher = new Teacher();
            teacher.FirstName = "Reza";
            teacher.DateOfBirth = new DateTime();
            string info = person.GetBasicInfo(teacher);
            return Ok(info);
        }
    }
}
