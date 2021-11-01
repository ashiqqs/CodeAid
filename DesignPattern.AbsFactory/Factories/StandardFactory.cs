using DesignPattern.AbsFactory.Delivery;
using DesignPattern.AbsFactory.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbsFactory.Factories
{
    public class StandardFactory : Factory
    {
        internal override Package CreatePackaging()
        {
            return new StandardPackaging();
        }

        internal override Deliver CreateDeliver()
        {
            return new StandardDelivery();
        }

        internal override string GetName()
        {
            return "Standard";
        }
    }
}
