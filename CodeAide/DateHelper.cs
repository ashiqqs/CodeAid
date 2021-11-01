using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAide
{
    public class DateHelper : IDateHelper
    {
        public (byte Years, byte Months, byte Days) GetAge(DateTime dateOfBirth)
        {
            var diff = DateTime.Now - dateOfBirth ;
            var years = ((diff.TotalDays) / 365);
            var month = ((diff.TotalDays % 365) / 30);
            var days = (diff.TotalDays % 30);
            return ((byte)years, (byte)month, (byte)days);
        }
    }
}
