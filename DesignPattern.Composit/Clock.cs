using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composit
{
    public class Clock : IComponent
    {
        public DateTime CurrentTime;
        public string OfficeName;
        public void Add(IComponent notifier)
        {
            throw new Exception("You cannot add clock");
        }

        public void SetTime(DateTime time)
        {
            CurrentTime = time;
        }

        public void ShowTime()
        {
            Console.WriteLine(OfficeName+": Current time "+CurrentTime.ToString("hh:mm:ss:tt"));
        }
    }
}
