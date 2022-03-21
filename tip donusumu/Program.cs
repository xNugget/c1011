using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte a = 15;
            sbyte b = 35;
            short c = 15;
            int d = a+b+c;
            Console.WriteLine("d;" + d);
            long h = d;
            Console.WriteLine("h:" + h);
            float i = h;
            Console.WriteLine("i:" + i);
            string e = "beko";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g:" + g);    
            /// aaaaaaaaaa
            int x = 4;
            byte y = (byte)x;
             Console.WriteLine("y:" +y);
            int z = 100 ;
            byte t = (byte)z;
            Console.WriteLine("t:" +t);
            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" +v);
            // *** Tostring *****
            Console.WriteLine("Tostring");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" +yy);
             string zz = 12.5f.ToString();
             Console.WriteLine("zz:" + zz);
             string s1 ="10", s2="28";
            //aare
             int sayi1, sayi2;
             int Toplam;
             sayi1 = Convert. ToInt32(s1);
             sayi2 = Convert. ToInt32(s2);
            Toplam = sayi1 + sayi2;
             Console.WriteLine("Toplam:" + Toplam);
                //Parse
                        Console.WriteLine("***** Parse *****");
                    ParseMethod();

        }
          public static void ParseMethod()
    {
        string metin1 = "10";
        string metin2 = "10.25";
        int rakam1;
        double double1;

        rakam1 = Int32. Parse(metin1);
        double1 = Double.Parse(metin2);
        Console.WriteLine("rakam1 :" + rakam1);
        Console.WriteLine("doublel :" + double1);
    }

        
    }
  
    
}