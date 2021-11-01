using DesignPattern.AbsFactory.Delivery;
using DesignPattern.AbsFactory.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbsFactory.Factories
{
    public class NormalFactory : Factory
    {
        internal override Package CreatePackaging()
        {
            return new NormalPackaging();
        }

        internal override Deliver CreateDeliver()
        {
            return new NormalDelivery();
        }

        internal override string GetName()
        {
            return "Normal";
        }
    }
}
