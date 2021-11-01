using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAide
{
    public interface IDateHelper
    {
        (byte Years, byte Months, byte Days) GetAge(DateTime dateOfBirth);
    }
}
