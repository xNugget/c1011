string degisken = "bir iki üc";
string degisken2 = "iki"; 
//Length;
Console.WriteLine(degisken.Length);
//ToUpper, ToLower
Console.WriteLine(degisken. ToUpper());
Console.WriteLine(degisken. ToLower());
//Concat
Console.WriteLine(String.Concat(degisken," dort"));
//Compare, Compareto
Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
Console.WriteLine(String.Compare(degisken, degisken2, true));
Console.WriteLine(String.Compare(degisken, degisken2, false));
//Contains
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("armut"));
Console.WriteLine(degisken.StartsWith("Merhaba!"));
//Index0f
Console.WriteLine(degisken.IndexOf("ik"));
Console.WriteLine(degisken.IndexOf("yedi"));
Console.WriteLine(degisken.LastIndexOf("i"));
//Insert
Console.WriteLine(degisken. Insert(0, "Merhaba! "));
//PadLeft, PadRight;
Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
Console.WriteLine(degisken. PadRight(50) + degisken2);
Console.WriteLine(degisken.PadRight(50,'-') + degisken2);
//Remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken. Remove(0,1));
//Replace
Console.WriteLine(degisken.Replace("üc", "bes"));
Console.WriteLine(degisken.Replace(" ",""));
//Split
Console.WriteLine(degisken.Split(' ')[1]);
//Substring
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,2));

//cevaplar
// 10
// BİR İKİ ÜC
// bir iki üc
// bir iki üc dort
// -1
// -1
// -1
// True
// False
// False
// 4
// -1
// 6
// Merhaba! bir iki üc
// bir iki üc                           iki
// bir iki üc***************************iki
// bir iki üc                                        iki
// bir iki üc----------------------------------------iki
// bir iki üc
// bir iüc
// ir iki üc
// bir iki bes
// birikiüc
// iki
// iki üc
// ik
