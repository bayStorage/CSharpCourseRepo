using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            //NewMethod1();
            //NewMethod2();
            //NewMethod3();


            if (IsPrimeNumber(5))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();

        }


        private static bool IsPrimeNumber(int number)
        {

            bool result = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;

                }

            }
            return result;

        }


        private static void NewMethod3()
        {
            string[] studens = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in studens)
            {

                Console.WriteLine(student);
            }
        }

        private static void NewMethod2()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);

        }

        private static void NewMethod1()
        {
            int number = 100;

            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now Number is {0}", number);
        }

        private static void NewMethod()
        {
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}
