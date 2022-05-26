using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();

            string sentence = "My name is Sinan Bayraktar";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is BayStorage";

            bool result3 = sentence.EndsWith("e"); //E harfi ile bitip bitmediğine bakar.
            bool result4 = sentence.StartsWith("My name"); //My name ile başlayıp başlamadığına bakar.

            var result5 = sentence.IndexOf("name");//Girilen indexin nerede olduğunu gösterir.
            var result6 = sentence.IndexOf(" ");//Baştan başlayarak ararma yapar.
            var result7 = sentence.LastIndexOf(" ");//Sondan arama *sıfırdan sayma başlar.
            var result8 = sentence.Insert(0, "Hello ");// Ekleme
            var result9 = sentence.Substring(5,5);//5 karakterden itibare n5 karakter al.
            var result10 = sentence.ToLower();//Bütün harfleri küçültür.
            var result11 = sentence.ToUpper();//Bütün harfleri büyültür.
            var result12 = sentence.Replace(" ", "-");//Boşluklar yerine çizgi getirir.
            var result13 = sentence.Remove(3,5);//3 karakterden sonrasını remove eder.//3. karakterden itibaren 5 karkteri sil.


            Console.WriteLine(result13);

            Console.ReadLine();
        }






        private static void NewMethod()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                //Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            //Console.WriteLine(result);
            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
