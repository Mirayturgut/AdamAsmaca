
using System.Runtime.InteropServices.ComTypes;

Console.WriteLine("----ADAM ASMACA----");
Console.WriteLine(" O");
Console.WriteLine("/|\\");
Console.WriteLine("/\\");
List<string> Kelimeler = new List<string>() {"elma", "masa", "kalem","araba","bilgisayar","kahve", "lamba"};

Random rnd = new Random();  //Rastgele sayı üretici oluşturur.
string seciliKelime = Kelimeler[rnd.Next(Kelimeler.Count)]; // 0 ile dizi uzunluğu arasında rastgele bir sayı üretir.
//Böylece diziden rastgele bir kelime seçilir.

char[] gizliKelime = new char[seciliKelime.Length]; // Tahmin edilen harfleri göstermek için karakter dizisi oluşturur.
for (int i = 0; i < seciliKelime.Length; i++)
{
    gizliKelime[i] = '*';  // Başlangıçta her harf * ile gizleniyor.
}
int KalanHak = 6;
List<char>tahminEdilenHarfler = new List<char>(); // Oyuncunun bildiği harfler buraya eklenir.

while (KalanHak > 0 && new string(gizliKelime) != seciliKelime) // Hak 0 olursa oyun biter / Oyuncu kelimeyi tam bilirse oyun biter
{
    Console.Clear();
    Console.WriteLine("Kelime:" + new string(gizliKelime));
    Console.WriteLine("Kalan Hak: " + KalanHak);
    Console.WriteLine("Bir harf tahmin et: ");
    char tahmin = Console.ReadKey().KeyChar; // girilen tuşun karakterini alır
    Console.WriteLine();
    
    if (tahminEdilenHarfler.Contains(tahmin))
    {
        Console.WriteLine("Bu harfi zaten tahmin ettin.");
        continue; // Kullanıcı daha önce bu harfi girdiyse uyarı verir ve bu tut atlar.(continue)
    }

    tahminEdilenHarfler.Add(tahmin); //Harf ilk kez girildiyse tahmin listesine eklenir

    if (seciliKelime.Contains(tahmin))
    {
        for (int i = 0; i < seciliKelime.Length; i++)
        {
            if (seciliKelime[i] == tahmin)
            {
                gizliKelime[i] = tahmin;  // gizliKelime dizisinde ki * yerine harf yazılır.
            }
        }
        Console.WriteLine("Doğru tahmin!");
    }
    else
    {
        KalanHak--; //Haktan 1 düşürülür
        Console.WriteLine("Yanlış tahmin.");
    }

    Console.WriteLine("Devam etmek için bir tuşa bas..."); 
    Console.ReadKey();
}

// 5. Oyun sonucu
Console.Clear();
if (new string(gizliKelime) == (seciliKelime))
{
    Console.WriteLine("Tebrikler! Kelimeyi bildiniz:");
    Console.WriteLine(seciliKelime);
}
else
{
    Console.WriteLine("Hakkınız bitti. Kelime: " + seciliKelime);
}

//List<string>	Kelimeleri tutar
//Random	    Rastgele kelime seçmek için
//char[]	    Gizli kelimeyi harf harf göstermek için
//while	        Oyun döngüsünü kontrol eder
//List<char>	       Tahmin edilen harfleri tutar, tekrar kontrolü sağlar
//Console.Clear()	   Ekranı her turda temizlemek için
//Console.ReadKey().KeyChar	    Tek harf girişi almak için
//if, else	    Doğru mu yanlış mı kontrol eder
//continue	    Aynı harf tekrar girildiyse o turu geçmek için kullanılır.






