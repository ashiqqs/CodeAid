using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class TeaBase : Base
    {
        public override string OrderDetail()
        {
            return "Getting tea";
        }
    }
}
