using Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10); //burada verilen değer daha önceliklidir.
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DataBaseLogger());
            employeeManager.Add();


            PersonManager personManager = new PersonManager("Product");
            personManager.Add();



            Teacher.Number = 10;
            Utilities.Validate();

            Manager.DoSomething();
            Manager DoSomething2 = new DoSomething2();
            Manager.DoSomething2();

            Console.ReadLine();


        }
    }

    class CustomerManager
    {
        private int _count = 15; //private değişkenler alt çizgi ile başlar.
        public CustomerManager(int count)
        {
            _count = count;

        }

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed!  {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added  {0} items", _count);
        }
    }
    class Product
    {
        public Product()
        {

        }
        private string _name;
        private int _id;
        private int v1;
        private string v2;

        public Product(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public Product(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }

    interface ILogger
    {
        void Log();

    }
    class DataBaseLogger : ILogger
    {

        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        //public ILogger Logger { get; set; } //bunun yerine aşağıdaki methodu kullandık.
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            this._entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    static class Teacher //Kullanımı kolay fakat bütün clientte aynı değeri almaktadır.
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done-2");
        }
    }
}

