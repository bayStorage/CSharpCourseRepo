using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer(FirstName = "Sinan"), new Customer(FirstName = "BayS"));
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    class Product : IEntity
    {

    }

    interface IProductDal : IRepository<Product>
    {

    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }
    interface ICustomertDal : IRepository<Customer>
    {

    }

    interface IStudentDal : IRepository<Student> //<string> koyduğumuzda newlenemediği için çalışmaz.
    {

    }
    class Student : IEntity
    {

    }
    interface IEntity
    {

    }

    interface IRepository<T> where T : class, IEntity, new() //hem class hemde newlenebilir olmalıdır. //new() herzaman en sonayazılır.
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }


}
