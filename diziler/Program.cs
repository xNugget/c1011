using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Console.Write("kaç dizi eleman");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayıdizisi = new int[diziuzunlugu];
            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("{0} . sayıyı gir : ", i+1);
                sayıdizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0 ;
            foreach (var sayi in sayıdizisi)
            {
                toplam += sayi;
                
            }
            Console.WriteLine("ortalama : "+ toplam/diziuzunlugu);

        }
    }
}