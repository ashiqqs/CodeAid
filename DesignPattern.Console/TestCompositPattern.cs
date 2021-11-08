using DesignPattern.Composit;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DesignPattern.Console
{
    public class TestCompositPattern
    {
        public static void Test()
        {
           Office _headOffice = new Office();
            _headOffice.Add(new Clock { CurrentTime = DateTime.Now.AddMinutes(1), OfficeName = "Head Office" });
            _headOffice.Add(new Clock { CurrentTime = DateTime.Now.AddMinutes(3), OfficeName = "Head Office" });

            Office _branch1 = new Office();
            _branch1.Add(new Clock { CurrentTime = DateTime.Now.AddMinutes(2), OfficeName = "Branch1 Office" });
            _branch1.Add(new Clock { CurrentTime = DateTime.Now.AddMinutes(5), OfficeName = "Branch1 Office" });
            _headOffice.Add(_branch1);

            Office _branch2 = new Office();
            _branch2.Add(new Clock { CurrentTime = DateTime.Now.AddMinutes(6), OfficeName = "Branch2 Office" });
            _branch2.Add(new Clock { CurrentTime = DateTime.Now.AddMinutes(4), OfficeName = "Branch2 Office" });
            _headOffice.Add(_branch2);

            WriteLine("Before Reset:");
            WriteLine("---------------------------------------------");
            _headOffice.ShowTime();
            WriteLine("\nAfter Reset:");
            WriteLine("---------------------------------------------");
            _headOffice.SetTime(DateTime.Now.AddMinutes(10));



        }
    }
}
