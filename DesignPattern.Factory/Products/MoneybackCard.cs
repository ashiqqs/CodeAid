using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory.Products
{
    class MoneybackCard:CreditCard
    {
        private string _cardType;
        private double _charge;
        private double _limit;

        public MoneybackCard(double charge, double limit)
        {
            _cardType = "Moneyback credit card";
            _charge = charge;
            _limit = limit;
        }
        public override string Type
        {
            get { return _cardType; }
        }
        public override double CreditLimit
        {
            get { return _limit; }
            set { _limit = value; }
        }
        public override double AnnualCharge
        {
            get { return _charge; }
            set { _charge = value; }
        }
    }
}
