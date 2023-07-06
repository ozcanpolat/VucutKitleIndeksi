using System;
using System.ComponentModel.DataAnnotations;

namespace ParolaveMailDogruluk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parola ve email bilgisini isteyip doğruluğunu kontrol ediniz.

            string _email = "ozcan@gmail.com";
            string _parola = "123456";

            Console.Write("E-mail adresinizi girin :");
            string email = Console.ReadLine();

            Console.Write("Şifrenizi girin :");
            string parola = Console.ReadLine();

            var result = (_email == email) && (_parola == parola);
            Console.WriteLine("Tebrikler. Giriş Başarılı .");


        }
    }
}
