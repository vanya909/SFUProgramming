using System;
using System.Collections.Generic;

namespace FirstLabSecondSem
{
    class Program
    {
        static string message = "";

        static void Main(string[] args)
        {
            U_Market market = new U_Market();

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(market);
            }
        }

        private static bool MainMenu(U_Market market)
        {
            Console.Clear();
            if (message.Length != 0)
                Console.WriteLine(message);
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add good to cart");
            Console.WriteLine("2) Clear the cart");
            Console.WriteLine("3) Balance");
            Console.WriteLine("4) Show all goods in the cart");
            Console.Write("\r\nSelect an option: ");
            message = "";

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Type good name");
                string goodName = Console.ReadLine();
                Console.Write("Type count");
                int count = Convert.ToInt32(Console.ReadLine());
                try
                {
                    market.AddGoodToCart(goodName, count);
                }
                catch (KeyNotFoundException k)
                {
                    message = k.Message;
                }
                return true;
            }
            else if (input == "2")
            {
                market.FoodCart.Foodstuffs.Clear();
                return true;
            }
            else if (input == "3")
            {
                market.FoodCart.CartBalansing();
                return true;
            }
            else if (input == "4")
            {
                message = market.FoodCart.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
