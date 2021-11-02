using DesignPattern.Factory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory.Factories
{
    public abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
