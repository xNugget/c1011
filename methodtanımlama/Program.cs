using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            int a =5;
            int b = 9;
            Console.WriteLine(a+b);

            

            int sonuc= eee(a,b);
            Console.WriteLine(sonuc);

            methods ornek=new methods();
            ornek.EkranaYaz(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırveTopla(ref a , ref b);
            ornek.EkranaYaz(Convert.ToString(sonuc2));
            ornek.EkranaYaz(Convert.ToString(a+b));
            

        }
         int eee(int sayi1,int sayi2)
{
return(sayi1 + sayi2);
}
    }


}
class methods
{
    public void EkranaYaz(string veri)
    {
        Console.WriteLine(veri);
    }
    public int ArttırveTopla(ref int deger1,ref int deger2)
    {
        deger1+=1;
        deger2+=1;
        return(deger1+deger2);
    }
}