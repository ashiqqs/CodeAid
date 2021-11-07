using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class SugerFree:DecoratorBase
    {
        public SugerFree(Base B):base(B)
        {

        }

        public override string OrderDetail()
        {
            return BaseObj.OrderDetail() + " + Without sugar";
        }
    }
}
