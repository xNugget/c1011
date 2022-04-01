using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islemler instance = new();
            Console.WriteLine(instance.Expo(2,22));

            //extension
            string ifade ="Bekoooooo Kekoo";
            bool sonuc = ifade.Boslukkontrol();
            Console.WriteLine(sonuc);

            if(sonuc)
            Console.WriteLine(ifade.Bosluklarısil);

            Console.WriteLine(ifade.HarfleriBuyut);
            Console.WriteLine(ifade.HarfleriKucult);

            int[] dizi = {9,5,2,4,2,6,7,8,1};
            dizi.sortarray();
            dizi.ekranayazdir();
            
            int sayi = 5;
            Console.WriteLine(sayi.ciftmi());

            Console.WriteLine(ifade.ilkharfial());
        
        }
    }
}
public class islemler
{
    public int Expo(int sayi,int üs)
    {
        if(üs<2)
        return sayi;
        return Expo(sayi,üs-1)*sayi;
    }

}
public static class Extension
{
    public static bool Boslukkontrol(this string karam)
    {
        return karam.Contains(" ");
    }
    public static string Bosluklarısil(this string karam)
    {
        string[] dizi = karam.Split(" ");
        return string.Join("*",dizi);
    }
    public static string HarfleriBuyut(this string karam)
    {
        return karam.ToUpper();
    }
    public static string HarfleriKucult(this string karam)
    {
        return karam.ToLower();
    }
    public static int[] sortarray(this int[] karam)
    {
        Array.Sort(karam);
        return karam;
    }
    public static bool ciftmi(this int karam)
    {
        return karam%2 == 0;
    }
    public static string ilkharfial(this string karam)
    {
        return karam.Substring(0,1);
    }
    public static void ekranayazdir(this int[] karam)
    {
        foreach (var item in karam)
        {
            Console.WriteLine(item);
        }
    }

}