using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory.Products
{
    public abstract class CreditCard
    {
        public abstract string Type { get; }
        public abstract double CreditLimit { get; set; }
        public abstract double AnnualCharge { get; set; }
    }
}
