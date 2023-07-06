using System;

namespace VucutKitleIndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kişinin ad, kilo ve boy bilgilerini alıp kilo indekslerini hesaplayınız.
            // Formül: (Kilo / boy uzunluğunun karesi)
            // Aşağıdaki tabloya göre kişi hangi gruba girmektedir.
            // 0-18.4    => Zayıf 
            // 18.5-24.9 => Normal  
            // 25.0-29.9 => Fazla Kilolu
            // 30.0-34.9 => Şişman (Obez)

            Console.Write("Adınızı girin :");
            string ad = Console.ReadLine();

            Console.Write("Kilonuzu girin :");
            float kilo = float.Parse(Console.ReadLine());

            Console.Write("Boyunuzu girin :");
            float boy = float.Parse(Console.ReadLine());

            float indeks = (kilo) / (boy * boy);

            var zayif = (indeks >= 0) && (indeks <= 18.4);
            var normal = (indeks > 18.4) && (indeks <= 24.9);
            var kilolu = (indeks > 24.9) && (indeks <= 29.9);
            var obez = (indeks > 29.9) && (indeks <= 34.9);

            Console.WriteLine($"{ad} Vücut Kitle İndeksin : {indeks}");
            Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen zayıf: {zayif}");
            Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen normal: {normal}");
            Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen kilolu: {kilolu}");
            Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen obez: {obez}");








        }
    }
}
