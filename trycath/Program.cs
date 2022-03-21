using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("sayı Gir");
            //      int sayi = Convert.ToInt32(Console.ReadLine());
            //       Console.WriteLine("Sayınız ; " + sayi);
            // }
            // catch(Exception ex)
            // {
            //         Console.WriteLine("hata ; " + ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("iislemokeyto");
            // }
            try
            {
               // int a = int.Parse(null);
              // int a = int.Parse("test");
              int a = int.Parse("-999999999999999999");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("boşggirdin");
                Console.WriteLine(ex);               
        
            }
            catch(FormatException ex)
        
            {
           Console.WriteLine("veri tipi uygun dğeil");
           Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("çok büyük yada çok kücük sayı");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem okeyto bebito");
            }
            
        }
    }
}