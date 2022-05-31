using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product keyboard = new Product(50);
            keyboard.ProductName = "Logitech";

            Product mouse = new Product(150);
            mouse.ProductName = "Razer";
            mouse.StockControlEvent += Mouse_StockControlEvent;



            for (int i = 0; i < 10; i++)
            {
                keyboard.Sell(10);
                mouse.Sell(20);

                Console.ReadLine();

            }

        }

        private static void Mouse_StockControlEvent()
        {
            Console.WriteLine("Mouse about to Finish !!!");
        }
    }
}
