using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayıDizisi = {5 , 12 ,13 ,2, 15, 66};
            Array.Sort(sayıDizisi);
            foreach (var sayı in sayıDizisi)
            {
                Console.WriteLine(sayı);
            }
            // //clear
            // Console.WriteLine("clear");
            // Array.Clear(sayıDizisi,2,3); 
            // foreach (var sayı in sayıDizisi)
            // {
            //     Console.WriteLine(sayı);
            // }
            Console.WriteLine("reverse");
            Array.Reverse(sayıDizisi);
            foreach (var sayı in sayıDizisi)
            {
                Console.WriteLine(sayı);
            }

            Console.WriteLine("indexof");
            Console.WriteLine(Array.IndexOf(sayıDizisi,15));

            Console.WriteLine("resize");
            Array.Resize<int>(ref sayıDizisi,9);
            sayıDizisi[7] = 1215;
            sayıDizisi[8] = 54546;
            
            foreach (var sayı in sayıDizisi)
            {
                Console.WriteLine(sayı);
            }
            



        }
    }
}