using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var total = Add2(20);
            Console.WriteLine(total);

            int number1 = 20;
            int number2;
            var result = Add3(ref number1, out number2); //ref referansı değiştirir yani aslında değişikliğe uğrar.//out başlangıç değeri girmemiz gerekmektedir.


            Console.WriteLine(total);
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(5, 5, 6, 6, 5));


            Console.ReadLine();

        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1 = 55, int number2 = 45)//default değer
        {

            var total = number1 + number2;
            return total;

        }

        static int Add3(ref int number1, out int number2)
        {
            number1 = 30;
            number2 = 100;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }


        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}
