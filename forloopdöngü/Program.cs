using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı gir");
            int sayac = int.Parse(Console.ReadLine());


            for (int i = 0; i < sayac; i++)
            {
                if(i % 2== 1 )
                {
                    Console.WriteLine(i);
                }
            }
            int tekt = 0;
            int ciftt = 0;
            for (int i = 0; i < 500; i++)
            {
                if (i%2 == 1 )
                tekt += i;
                else
                ciftt += i;
                

            }
            Console.WriteLine("tektoplam : " + tekt);
                Console.WriteLine("cifttoplam : " + ciftt);
                for (int i = 0; i < 10; i++)
                {
                    if(i == 2)
                    break;
                    Console.WriteLine(i);
                }
                for (int i = 0; i < 10; i++)
                {
                    if(i == 2)
                    continue;
                                        Console.WriteLine(i);
                }
        }
                
    }
}