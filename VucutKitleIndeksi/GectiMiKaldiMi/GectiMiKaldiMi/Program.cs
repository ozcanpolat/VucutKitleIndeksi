using System;

namespace GectiMiKaldiMi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 vize(% 60) ve final(% 40) notunu alıp ortalama hesaplayınız.
            //     Eğer ortalama 50 ve üstündeyse geçti değilse kaldı yazdırın.
            // Finalden 70 alındığında ortalamanın önemi olmasın.

            Console.Write("İlk vize notunuzu girin :");
            int vize1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci vize notunuzu girin :");
            int vize2 = int.Parse(Console.ReadLine());

            Console.Write("Final notunuzu girin :");
            int final = int.Parse(Console.ReadLine());

            var ortalama = ((vize1 + vize2) / 2) * 0.6 + (final * 0.4);       
            var durum = (ortalama>=50) || (final>=70);

            Console.WriteLine("ortalama: "+ ortalama);
            Console.WriteLine(durum?"geçti":"kaldı");
        }
    }
}
