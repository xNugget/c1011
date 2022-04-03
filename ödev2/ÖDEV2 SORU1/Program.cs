using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList arrayList = new ArrayList();
            ArrayList asalList = new ArrayList();
            ArrayList notasalList = new ArrayList();
            Console.WriteLine("20 sayı gir : \n");
            int counter = 0;
            for (int i = 0; i < 20 + counter; i++)
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n < 0)
                    {
                        Console.WriteLine("Please Enter positive number, add one more number.");
                        counter++;
                    }
                    else
                    {
                        arrayList.Add(n);
                    }

                }
                catch (Exception)
                {
                    counter++;
                    Console.WriteLine("\nError, add one more NUMBER!\n");
                }

            }

            foreach (int input in arrayList)
            {
                int control = 0;

                if (input < 0)
                {
                    //Console.WriteLine("\nPlease enter a positive number.\n");

                }
                else if (input == 0)
                {
                    //Console.WriteLine(input + " is not prime number");
                    notasalList.Add(input);
                }
                else if (input == 1)
                {
                    //Console.WriteLine(input + " is not prime number");
                    notasalList.Add(input);
                }
                else if (input == 2)
                {
                    //Console.WriteLine(input + " is a prime number");
                    asalList.Add(input);
                }
                else
                {
                    for (int i = 2; i < input; i++)
                    {
                        if (input % i == 0)
                            control++;
                    }

                    if (control != 0)
                        notasalList.Add(input);
                    else
                        asalList.Add(input);
                }
            }
            asalList.Sort();
            asalList.Reverse();
            notasalList.Sort();
            notasalList.Reverse();
            int asaltoplam= 0;
            int notasaltoplam=0;
            foreach (var item in asalList)
            {
                Console.Write(" "+item);
                asaltoplam +=(int)item;

            }
            foreach (var item in notasalList)
            {
                Console.Write(" "+item);
                notasaltoplam+=(int)item;
            }
            Console.WriteLine("asaolanlarıneleman sayısı : "+ asalList.Count + "ortalaması : " + (asaltoplam/notasalList.Count));
            Console.WriteLine("asalolmayan eleman sayısı : "+ notasalList.Count + "ortalaması : " + (notasaltoplam/notasalList.Count));
                
    
        }
    }
    
}
