using DesignPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DesignPattern.Console
{
    public class TestDecoratorPattern
    {
        public static void Test()
        {
            Base tea = new TeaBase();
            WriteLine(tea.OrderDetail());

            tea = new GingerTea(tea);
            WriteLine(tea.OrderDetail());

            tea = new CoffeeTea(tea);
            WriteLine(tea.OrderDetail());

            tea = new SugerFree(new CoffeeTea(new GingerTea(new TeaBase())));
            WriteLine(tea.OrderDetail()); //OUTPUT: Getting tea + Ginger + coffee flavour + sugger free
        }
    }
}
