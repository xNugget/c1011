using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] inputNumbers = new int[20];

            int[] buyukler = new int[3];
            int[] kucukler = new int[3];

           
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }
            

            Array.Sort(inputNumbers);
            for (int i = 0; i < 3; i++)
            {
                kucukler[i] = inputNumbers[i];
            }

            Array.Reverse(inputNumbers);
            for (int i = 0; i < 3; i++)
            {
                buyukler[i] = inputNumbers[i];
            }
            
            Console.WriteLine("En Büyük 3 Sayı");
            foreach (var item in buyukler)
                Console.WriteLine(item);
            

            Console.WriteLine("En Küçük 3 Sayı");

            foreach (var item in kucukler)
                Console.WriteLine(item);


            Console.WriteLine("Büyük Sayıların Ortalaması:" + buyukler.Average().ToString("00.00"));
            Console.WriteLine("Küçük Sayıların Ortalaması:" + kucukler.Average());
            
            Console.WriteLine("Büyük ve Küçük Sayıların Ortalama Toplamı:" + 
                (buyukler.Average() + kucukler.Average()).ToString("00.00"));





        }
    }
}