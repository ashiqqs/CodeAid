using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAide.TestHelper.Console
{
    public class TestDateHelper
    {
        private static IDateHelper dateHelper;
        public TestDateHelper()
        {
            dateHelper = new DateHelper();
        }

        public void  GetAge()
        {
            var age = dateHelper.GetAge(new DateTime(1999, 6, 1));
            System.Console.WriteLine($"{age.Years} years {age.Months} month {age.Days} days");
        }
    }
}
