using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac <= sayı)
            {
                toplam += sayac;
                sayac ++;

            }
            Console.WriteLine(toplam/sayac);
        

        char character = 'a';
        while (character < 'z')
        {
            Console.WriteLine(character);
            character ++;
        }

        string[] iller = {"aydın","izmir","istanbul","leblebi"};
        foreach (var il in iller)
        {
            Console.WriteLine(il);
        }
        }
    }
}