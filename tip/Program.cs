using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           byte a1 = 1;
           sbyte b1 = 2;
           short c1 = 30;
           int d = a1+b1+c1;
           Console.WriteLine("d"+  d);
           // long float
           string e = "elmas";
           char u ='v';
           object hepsi = e + u;
           Console.WriteLine(hepsi);
           int a2 = 5;
           byte a2b =(byte)a2;
           Console.WriteLine(a2b);
           //float
           int yy = 55555555;
           string yystring = yy.ToString();
           Console.WriteLine(yystring);
           //float
           string ao = "33" , bo = "44";
           int aoo , boo ;
           int toplamoo ;
           aoo = Convert.ToInt32(ao);
           boo = Convert.ToInt32(bo);
           toplamoo = aoo + boo ;
           Console.WriteLine("ooooooo" + toplamoo);
           ParseMethod();


        }
        public static void ParseMethod();
        {
            string metin1 = "22.333";
            string metin2 = "11.222";
            int rakam1;
            double dd25;
        rakam1 = Int32.Parse(metin1);
        dd25 = Double.Parse(metin2);
        Console.WriteLine(rakam1 + dd25);
        



        }
    }
}