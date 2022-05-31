using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegateTwo(string text);
    public delegate int MyDelegateThree(int numberOne, int numberTwo);

    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.SendMessage;

            MyDelegateTwo myDelegateTwo = customerManager.SendMessageTwo;
            myDelegateTwo += customerManager.ShowAlertTwo;

            Matematik matematik = new Matematik();
            MyDelegateThree myDelegateThree = matematik.Topla;
            myDelegateThree += matematik.Carp;

            var sonuc = myDelegateThree(2, 3);
            Console.WriteLine(sonuc);

            myDelegate();
            myDelegateTwo("Hello");

            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void SendMessageTwo(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlertTwo(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik
    {
        public int Topla(int sayiOne, int sayiTwo)
        {
            return sayiOne + sayiTwo;
        }
        public int Carp(int sayiOne, int sayiTwo)
        {
            return sayiOne * sayiTwo;
        }
    }
}
