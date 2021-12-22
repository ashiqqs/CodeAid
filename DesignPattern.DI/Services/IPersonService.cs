using DesignPattern.DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DI.Services
{
    public interface IPersonService
    {
        string GetBasicInfo(Person person);
    }
}
