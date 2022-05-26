using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        private const char V = 'A';

        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("HelloWorld");


            byte number1 = 255; //byte ver tipini max alabileceği değeri
            short number2 = 32567; //short ver tipini max alabileceği değeri
            int number3 = 2147483647; //int ver tipini max alabileceği değeri
            long number4 = 9223372036854775807; //long ver tipini max alabileceği değeri
            double number5 = 10.265646; //64 
            decimal number6 = 10;

            var number7 = 25;


            bool condition = false;
            char charter = 'A';



            Console.WriteLine("Number1 is = {0}",number1);
            Console.WriteLine("Number2 is = {0}",number2);
            Console.WriteLine("Number3 is = {0}", number3);
            Console.WriteLine("Number4 is = {0}", number4);
            Console.WriteLine("Number5 is = {0}", number5);
            Console.WriteLine("Number6 is = {0}", number6);
            Console.WriteLine("Number7 is = {0}", number7);
            Console.WriteLine("Condition is = {0}", condition);
            Console.WriteLine("Charter is : {0} " ,charter);

            Console.ReadLine();
        }
    }
}
