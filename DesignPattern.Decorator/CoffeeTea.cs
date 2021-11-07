using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class CoffeeTea : DecoratorBase
    {
        public CoffeeTea(Base B):base(B)
        {

        }
        public override string OrderDetail()
        {
            return BaseObj.OrderDetail() + " + coffee flavour";
        }
    }
}
