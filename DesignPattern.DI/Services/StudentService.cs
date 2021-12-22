using DesignPattern.DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DI.Services
{
    public class StudentService: IPersonService
    {
        public string GetBasicInfo(Person person)
        {
            StringBuilder info = new StringBuilder();
            info.Append($"Name: {person.FirstName} {person.LastName} \n");
            info.Append($"Birth Date: {person.DateOfBirth.ToString("MMM dd, yyyy")}\n");
            info.Append($"Designation: Student\n");
            return info.ToString();
        }
    }
}
