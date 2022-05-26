using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            customerManager.Add();
            Console.ReadLine(); ;
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; } //interface yeni nesne yaratma
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }
    class Logger
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }

    class FilebaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Filebase!");
        }
    }

    class SmsbaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Smsbase!");
        }
    }
}
