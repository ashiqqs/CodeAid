using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composit
{
    public interface IComponent
    {
        void Add(IComponent notifier);
        void SetTime(DateTime time);
        void ShowTime();
    }
}
