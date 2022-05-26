using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionInfo();


            try //try catch ile hata yakalama
            {
                Find();
            }
            catch (RecordNotFoundExxeption exception)
            {
                Console.WriteLine(exception.Message);

            }


            HandleException(() =>
            {

                Find();

            });//metod içinde method

            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundExxeption("Record not found"); // Hata mesajımızı oluşturmuş olduk.
            }
            else
            {
                Console.WriteLine("Record Found! ");
            }
        }

        private static void ExceptionInfo()
        {
            try
            {
                string[] students = new string[] { "Engin", "Derin", "Salih" };

                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {

                Console.WriteLine(exception.Message); //belirttiğimiz  hata varsa bu kod bloğunu çalıştırır.
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message); //Üst kısımda hata varsa ne için hata verdiğini hata mesajı olarak bizlere geri dönderir.
            }
        }
    }
}
