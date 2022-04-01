using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayi = "333";
            
            bool sonuc =int.TryParse(sayi , out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Successss");
                Console.WriteLine(outSayi);

            }
            else{
                Console.WriteLine("NOT SUCCESSSSSS");
            }
            methods instance = new methods();
            instance.Topla(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);
            

            int ifadee = 555;
            instance.EkranaYazdır(Convert.ToString(ifadee));
            instance.EkranaYazdır(ifadee);
        }
    }
    class methods
    {
        public void Topla(int a, int b,out int toplam)
        {
            toplam = a+b;
        }
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);

        }
        public void EkranaYazdır(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

    }
}