using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time>=6 && time<11)
        Console.WriteLine("Günaaaaydın!");
         else if(time<= 18)
         Console.WriteLine("iyi Günler!");
            else
            Console.WriteLine("iyi Geceler!");
        string sonuc = time<=18 ? "İyi Günler!" : "İyi Geceler!";
        sonuc = time>=6 && time<11 ?  "Günaydın!" : time <= 18 ? "İyi Gün ler!" :"İyi Geceler!";
        Console.WriteLine(sonuc);
        }
    }
}