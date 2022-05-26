using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Customer
    {
        private string name;
        protected int age;
        public int ıd;


    }

    class Student
    {
        public void Save()
        {
            Customer customer = new Customer();
            int ıd = customer.ıd;
            Console.WriteLine(ıd);
            Console.ReadLine();
        }
    }
}
