// Console.WriteLine("Pozitif Bir sayı giriniz :");
//             int sayi = int.Parse(Console.ReadLine());
//             int[] sayilar = new int[sayi];

//             for (int i = 0; i < sayi; i++)
//             {
//                 Console.WriteLine(i+1+". sayıyı giriniz");
//                 sayilar[i]= Convert.ToInt32(Console.ReadLine());
//             }
//             for (int i = 1; i < sayilar.Length; i++)
//             {
//                 int kalan = sayilar[i]%2;
//                 if(kalan==0){
//                 Console.WriteLine(sayilar[i]);
//             }
//             else
//             {}
//             }
// Console.WriteLine("2.soru");
// Console.WriteLine("böleni gir");
// int bolen = int.Parse(Console.ReadLine());
// Console.WriteLine("kaç kişi var");
// int sayi =int.Parse(Console.ReadLine());
// int[] sayilar = new int[sayi];

// for (int i = 0; i < sayi; i++)
// {
//     Console.WriteLine(i+1+". sayıyı giriniz");
//     sayilar[i]= Convert.ToInt32(Console.ReadLine());   
// }
// for (int i = 0; i < sayilar.Length; i++)
// {
//     if(sayilar[i]%bolen==0)
//     {
//         Console.WriteLine(sayilar[i]);
//     }
// }
// Console.WriteLine("3.soru");
// Console.WriteLine("kaç çeşit elma var");
// int elmasayisi = int.Parse(Console.ReadLine());
// string[] elmalar = new string[elmasayisi];
// for (int i = 0; i < elmasayisi; i++)
// {
//     Console.WriteLine(i+1+".renk gir");
//     elmalar[i]=Convert.ToString(Console.ReadLine());
// }
// Array.Reverse(elmalar);
// foreach (var elma in elmalar)
// {
//     Console.WriteLine(elma);
// }
Console.WriteLine("4.soru");
Console.WriteLine("cümle yaz , sana kaç kelime var kaç harf var onu söyleyeceğim anında");
string cumle = Convert.ToString(Console.ReadLine());
string[] kelimeler = cumle.Split(" ");
// char[] harfler = cumle.ToCharArray();
Console.WriteLine("{0} kelime var",kelimeler.Length);
string[] dizi = cumle.Split(" ");


Console.WriteLine("{0} harf var",cumle.Length);