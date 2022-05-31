using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3, 4));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());

            Thread.Sleep(1); //Programımızı 1 saniye bekletiyoruz.//sleep durumuna geçirmediğimiz zaman random sayı olarak aynı sayıyı döndermektedir.
            Func<int> getRandomNumberTwo = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumberTwo());

            Console.ReadLine();
        }

        static int Topla(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
