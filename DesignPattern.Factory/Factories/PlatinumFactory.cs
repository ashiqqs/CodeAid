using DesignPattern.Factory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory.Factories
{
    public class PlatinumFactory:CardFactory
    {
        private double _cardLimit;
        private double _annualCharge;

        public PlatinumFactory(double annualCharge, double cardLimit)
        {
            _cardLimit = cardLimit;
            _annualCharge = annualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new PlatinumCard(_annualCharge, _cardLimit);
        }
    }
}
