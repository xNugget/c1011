using System;

namespace operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int can = 100;
            int can2 = 200;
            can2 = can2+50;
            Console.WriteLine(can2);
            can2 += 5;
            Console.WriteLine(can2);
            can2 -= 10;
            Console.WriteLine(can2);
            can2 /= 5 ;
            Console.WriteLine(can2);
            
            bool kapıacıkmı = true;
            bool kedi = false;
            if(kapıacıkmı && kedi)
            Console.WriteLine("pisi pisi");
            if(kapıacıkmı || kedi)
            Console.WriteLine("pisi2");
            if(kapıacıkmı && !kedi)
            Console.WriteLine("pisi3");

            bool cancık = can2 > can;
            Console.WriteLine(cancık);
            cancık = can2<=can;
            Console.WriteLine(cancık);
            cancık = can2==can;
            Console.WriteLine(cancık);
            cancık = can2>=can;
            Console.WriteLine(cancık);
            cancık = can2!<=can;
            Console.WriteLine(cancık);
          
          int kafa1 = 1000;
          int kafa2 = 500;
          int kaafaa = kafa1 + kafa2;
          Console.WriteLine(kaafaa);
          kaafaa = kafa1 / kafa2;
          Console.WriteLine(kaafaa);
          



        


    

        }
    }
}