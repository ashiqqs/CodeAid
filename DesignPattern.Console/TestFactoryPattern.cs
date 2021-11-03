using DesignPattern.Factory.Factories;
using DesignPattern.Factory.Products;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DesignPattern.Console
{
    public class TestFactoryPattern
    {
        public static void Test()
        {
            CardFactory factory;
            byte cardType = 1;
            while (cardType >= 0)
            {
                WriteLine($"0.Exit 1.Moneyback 2.Platinum 3.Titanium");
                WriteLine($"-------------------------------------------");
                Write($"Enter card type to get details: ");
                byte.TryParse(ReadLine(), out cardType);

                switch (cardType)
                {
                    case 0:
                        WriteLine("You exit program.");
                        return;
                    case 1:
                        factory = new MoneybackFactory(50_000, 500);
                        break;
                    case 2:
                        factory = new PlatinumFactory(1_00_000, 1_000);
                        break;
                    case 3:
                        factory = new TitaniumFactory(5_00_000, 5_000);
                        break;
                    default:
                        WriteLine("Invalid selection.");
                        WriteLine();
                        continue;
                }
                CreditCard card = factory.GetCreditCard();
                WriteLine($"Card type: {card.Type}, Limit: {card.CreditLimit}, Annual Charge: {card.AnnualCharge}");
                WriteLine();
            }
        }
    }
}
