using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public abstract class DecoratorBase:Base
    {
        protected Base BaseObj { get; set; }
        public DecoratorBase(Base B)
        {
            BaseObj = B;
        }
    }
}
