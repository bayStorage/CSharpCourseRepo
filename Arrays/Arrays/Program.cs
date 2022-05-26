using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "engin";
            //students[1] = "derin";
            //students[2] = "salih";

            //string[] students2 = new string[3]{"Engin", "Derin", "Salih"};

            //foreach (string student in students2) //array içerisinde dolaşabilmemizi sağlamaktadır.
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balikesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Hakkari"},
                {"Rize","Trabzon","Giresun"},
                {"İzmir","Muğla","Manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) //dizi üst sınırı için kullanılıyor.
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {

                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*************");

            }



            Console.ReadLine();
        }
    }
}
