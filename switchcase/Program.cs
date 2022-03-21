using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            switch(month)
            {
                case 1: 
                Console.WriteLine("Ocak Ayı");
                break;
                 case 2: 
                Console.WriteLine("şubat Ayı");
                break;
                 case 3: 
                Console.WriteLine("mart Ayı");
                break;
                default:
                
                Console.WriteLine("yanlış veri");
                break;


            }
            switch(month)
            {
                case 1:
                case 2:
                case 12:
                Console.WriteLine("kış");
                break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("ilkbahar");
                break;
                default:
                break;


            }
        }
    }
}