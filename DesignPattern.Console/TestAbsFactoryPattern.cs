using DesignPattern.AbsFactory;
using DesignPattern.AbsFactory.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DesignPattern.Console
{
    public class TestAbsFactoryPattern
    {
        public static void Test()
        {
            Client client1 = new Client(new NormalFactory());
            WriteLine($"Factory Name: {client1.FactoryName}");
            WriteLine($"Pacage Details: {client1.ClientPackage.GetDetails()}");
            WriteLine($"Delivery charge: {client1.ClientDeliver.GetCharge()}");
            WriteLine();
            Client client2 = new Client(new StandardFactory());
            WriteLine($"Factory Name: {client2.FactoryName}");
            WriteLine($"Pacage Details: {client2.ClientPackage.GetDetails()}");
            WriteLine($"Delivery charge: {client2.ClientDeliver.GetCharge()}");

        }
    }
}
