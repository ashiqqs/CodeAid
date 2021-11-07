using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class GingerTea : DecoratorBase
    {
        public GingerTea(Base B): base(B)
        {

        }
        public override string OrderDetail()
        {
            return BaseObj.OrderDetail()+ " + Ginger";
        }
    }
}
