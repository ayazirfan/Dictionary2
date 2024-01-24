// Şehirler arası Telefon Kodları
using System.Globalization;

var telefonKodlari = new Dictionary<int, string>() { {332, "Konya"}, {424, "Elazığ"}, {466, "Artvin"}};

// ekleme
telefonKodlari.Add(322, "Adana");
telefonKodlari.Add(212, "İstanbul");
telefonKodlari.Add(216, "İstanbul");
telefonKodlari[422] = "Malatya";

// ConteinsKeys
if (!telefonKodlari.ContainsKey(312))
{
  System.Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil.!");
  telefonKodlari.Add(312, "Ankara");
  System.Console.WriteLine("Yeni kod eklendi.");  
}
// ContainsValue
if (!telefonKodlari.ContainsValue("Sivas"))
{
 System.Console.WriteLine("\aSivas'ın kod bilgisi tanımlı değil.!");
 telefonKodlari.Add(358, "Sivas");
 System.Console.WriteLine("Sivas'ın kod bilgisi eklendi.");   
}
telefonKodlari.Remove(424);
    

foreach (var s in telefonKodlari)
{
    System.Console.WriteLine(s);
}
// Personel bilgilerini tutan bir sözlük
var PersonelListesi = new Dictionary<int, Personel>()
{
{110, new Personel("Zeynep", "Sonsöz", 5000)},
{120, new Personel("Ahmet", "Can", 9000)}
};
PersonelListesi.Add(100, new Personel("Zeynep", "Coskun", 5000));
foreach (var p in PersonelListesi)
{
    System.Console.WriteLine(p);
}