using DesignPattern.AbsFactory.Delivery;
using DesignPattern.AbsFactory.Factories;
using DesignPattern.AbsFactory.Packaging;
using System;

namespace DesignPattern.AbsFactory
{
    public class Client
    {
        private Package _package;
        private Deliver _deliver;

        public Client(Factory factory)
        {
            _package = factory.CreatePackaging();
            _deliver = factory.CreateDeliver();
            FactoryName = factory.GetName();
        }

        public Package ClientPackage { get { return _package; } }
        public Deliver ClientDeliver { get { return _deliver; } }
        public string FactoryName { get; private set; }
    }

}
