using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringList();
            //ArrayList();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }




        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Istanbul");


            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Sinan" });
            customers.Add(new Customer { Id = 12, FirstName = "BayS" });

            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Storage"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]);
            {
                new Customer { Id = 3, FirstName = "Veli" };
                new Customer { Id = 5, FirstName = "Ali" };

                //customers.Clear(); Listeyi temizler.
                //customers.Contains(customer2); Listede olup olmadığını kontrol eder.
            }

            var index = customers.IndexOf(customer2);
            var index2 = customers.LastIndexOf(customer2);

            //customers.Insert(0,customer2); Listenin en başına ekleme yapar.
            //customers.Remove(customer2); listede aradığı elemanı bulur ve sadece ilk bulduğunu siler.

            Console.WriteLine("Index : {0}", index);
            Console.WriteLine("Index : {0}", index2);

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count();

            Console.WriteLine("Count : {0}", count);
        }

        private static void StringList()
        {
            string[] cities = new string[2] { "Ankara", "Antalya" };
            cities = new string[3];

            Console.WriteLine(cities[0]);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add("A");
        }

        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
    }
}

