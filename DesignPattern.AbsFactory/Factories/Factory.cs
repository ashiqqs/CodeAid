using DesignPattern.AbsFactory.Delivery;
using DesignPattern.AbsFactory.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbsFactory.Factories
{
    public abstract class Factory
    {
        internal abstract string GetName();
        internal abstract Package CreatePackaging();
        internal abstract Deliver CreateDeliver();
    }
}
