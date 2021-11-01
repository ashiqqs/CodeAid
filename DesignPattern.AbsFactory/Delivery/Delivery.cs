using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbsFactory.Delivery
{
    public abstract class Deliver {
        public abstract double GetCharge();
    };
    public class NormalDelivery : Deliver
    {
        public override double GetCharge()
        {
            return 1200;
        }
    }
    public class StandardDelivery : Deliver
    {
        public override double GetCharge()
        {
            return 1900;
        }
    }
}
