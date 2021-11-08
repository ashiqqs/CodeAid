using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composit
{
    public class Office : IComponent
    {
        private List<IComponent> _list = new List<IComponent>();
        public void Add(IComponent notifier)
        {
            _list.Add(notifier);
        }

        public void SetTime(DateTime time)
        {
            foreach(IComponent c in _list)
            {
                c.SetTime(time);
                if (c is Clock)
                {
                    c.ShowTime();
                }
            }
        }

        public void ShowTime()
        {
            foreach (IComponent c in _list)
            {
                c.ShowTime();
            }
        }
    }
}
