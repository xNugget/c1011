List<int> sayiListesi = new List<int>();
sayiListesi.Add(23);
sayiListesi.Add(11);
sayiListesi.Add(33);

List<string> renkListesi = new List<string>();
renkListesi.Add("LEBLEBİ");
renkListesi.Add("Patates");
renkListesi.Add("YEŞİL");
renkListesi.Add("Sarı");

//count
Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);

//Foreach

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}

foreach (var renk in renkListesi)
{
    Console.WriteLine(renk);
}
sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
renkListesi.ForEach(renk=>Console.WriteLine(renk));

//eleman çıkarma
sayiListesi.Remove(11);
renkListesi.Remove("Patates");

renkListesi.RemoveAt(0) ;

sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
renkListesi.ForEach(renk=>Console.WriteLine(renk));

//listeiçi arama
if(sayiListesi.Contains(33))
Console.WriteLine("listede 33 bulunamktadır");

//indexeulaşmak
Console.WriteLine(renkListesi.BinarySearch("Sarı"));

//diziyi list e çevirmek
string[] kuslar = {"Pembe", "Mor" , "Soğan"};
List<string> kuslarlistesi = new List<string>(kuslar);

//TEMİZLEME

kuslarlistesi.Clear();

 //LİST İÇERİSİNDE NESNE TUTMAK

 List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

 Kullanıcılar kullanıcı1 = new Kullanıcılar();
 kullanıcı1.Isim = "Portakal";
 kullanıcı1.Soyisim="Ordakal";
 kullanıcı1.Yas=99;

  Kullanıcılar kullanıcı2 = new Kullanıcılar();
 kullanıcı2.Isim = "Lebron";
 kullanıcı2.Soyisim="EEEE";
 kullanıcı2.Yas=55;

 kullanıcıListesi.Add(kullanıcı1);
  kullanıcıListesi.Add(kullanıcı2);

List<Kullanıcılar> yenilistem= new List<Kullanıcılar>();
yenilistem.Add(new Kullanıcılar(){
    Isim="patates",
    Soyisim="soğan",
    Yas=22

});
foreach (var kullanıcı in kullanıcıListesi)
{
    Console.WriteLine("id : "+kullanıcı.Isim);
    Console.WriteLine("sifre : "+kullanıcı.Soyisim);
    Console.WriteLine("pass : "+kullanıcı.Yas);
}

yenilistem.Clear();















public class Kullanıcılar{
    private string isim;
    private string soyisim;
    private int yas;
    public string Isim{get => isim; set=>isim=value;}
    public string Soyisim{get => soyisim; set=>soyisim=value;}
    public int Yas{get => yas; set=>yas=value;}
}