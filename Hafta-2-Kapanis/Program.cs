// Console.WriteLine ile metinler yazdırılıyor.
Console.WriteLine("-----------Cevap1----------");
Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen Nasılsın?");

//String ve integer'a değer verilyor sonrasında Console.WriteLine ile konsola yazdırılıyor.
Console.WriteLine("\n-----------Cevap2----------");
string metin = ("Metin yazılıyor.");
int sayi = 5;
Console.WriteLine(metin);
Console.WriteLine(sayi);

// Random commandi ile rastgele sayı belirleyip, rnd.Next değeri ile 1 ile 100 arasında rastgele sayı isityoruz.
Console.WriteLine("\n-----------Cevap3---------");
Random rnd = new Random();
int random = rnd.Next(1, 100);
Console.WriteLine("Rastgele sayi : " + random);

// Random sayı yazdırdıktan sonra % ibaresi ile kalan sayı Console.WriteLine ile konsola yazdırılıyor
Console.WriteLine("\n-----------Cevap4---------");
Random rand = new Random();
int remainder = rand.Next(1, 100);
int kalansayi = remainder % 3;
Console.WriteLine("Kalan Sayi: " + kalansayi);

//Kullanıcıdan girdi alıp, if-else ile büyük mü küçük mü saptıyoruz.
Console.WriteLine("\n-----------Cevap5---------");
Console.WriteLine("Kaç yaşındasınız?");
string cevap = Console.ReadLine();

if (int.TryParse(cevap, out int yas))
{
    if (yas >= 18)
        Console.WriteLine("(+)");
    else
        Console.WriteLine("(-)");
}
else
{
    Console.WriteLine("Geçerli bir yaş girin.");
}

// 10 defa aynı metni yazdırıyoruz.
Console.WriteLine("\n-----------Cevap6---------");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

Console.WriteLine("\n-----------Cevap7---------");
Console.WriteLine("Parantez içinde yazan metni giriniz (Gülse Birsel) ");
string Gulse = Console.ReadLine();
Console.WriteLine("Parantez içinde yazan metni giriniz (Demet Evgar) ");
string Demet = Console.ReadLine();

string degisim = Gulse;
Gulse = Demet;
Demet = degisim;

Console.WriteLine("Yer değiştirilmiş değerler:");
Console.WriteLine("\nBirinci metin: " + Gulse);
Console.WriteLine("İkinci metin: " + Demet);


// Değer döndürmeyen bir metot yazıyoruz.
Console.WriteLine("\n-----------Cevap8---------");
static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

BenDegerDondurmem(); // Metodu çalıştırır.

//2 sayının toplamını kullanıcıdan alıp bu değeri geri döndüren metot yazıyoruz.
Console.WriteLine("\n-----------Cevap9---------");
Console.WriteLine("\nLütfen ilk sayıyı giriniz");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı giriniz");
int b = Convert.ToInt32(Console.ReadLine());
static int toplam(int a, int b)
{
    return a + b;  // Kalan sayıyı geriye döndürüyor.
}
int result = toplam(a, b);
Console.WriteLine("\nToplama sonucu: " + result);

//
Console.WriteLine("\n-----------Cevap10---------");
Console.Write("Lütfen 'true' veya 'false' yazın: ");
string kullaniciGirdisi = Console.ReadLine();
string sonuc = BooleanToString(kullaniciGirdisi);
Console.WriteLine("Sonuç: " + sonuc);

static string BooleanToString(string input)
{
    if (Boolean.TryParse(input, out bool booleanDeğer))
    {
        return booleanDeğer.ToString(); // Boolean değeri string olarak dönüştürüyor
    }
    else
    {
        return "Geçersiz giriş. Lütfen 'true' veya 'false' yazın.";
    }
}

//Kullanıcıdan 3 tane yaş girmesini istiyoruz ve Math.Max commandi ile en büyük yaşı bulacağız.
Console.WriteLine("\n-----------Cevap11---------");
Console.WriteLine("1. kişinin yaşını giriniz");
int yas1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. kişinin yaşını giriniz");
int yas2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. kişinin yaşını giriniz");
int yas3 = Convert.ToInt32(Console.ReadLine());

int enBuyukYas = Math.Max(Math.Max(yas1, yas2), yas3);
Console.WriteLine($"En Büyük Yaş Değeri {enBuyukYas}");


Console.WriteLine("\n-----------Cevap12---------");
static int en_buyuk_sayi()
{
    Console.Write("Kaç sayı girmak istiyorsunuz :");
    int adet = Convert.ToInt32(Console.ReadLine());
    Console.Write("Sayı giriniz :");
    int sayi = Convert.ToInt32(Console.ReadLine());

    int max_Sayi = sayi;

    for (int i = 1; i < adet; i++)
    {
        Console.Write("Sayı giriniz :");
        sayi = Convert.ToInt32(Console.ReadLine());

        max_Sayi = Math.Max(sayi, max_Sayi);

    }
    Console.WriteLine("Max sayı :" + max_Sayi);
    return max_Sayi;

}
en_buyuk_sayi();

//İsim değişikliği yapmak için kullanıcıdan isim1 ve isim2 değerlerini alıyoruz.
Console.WriteLine("\n-----------Cevap13---------");
Console.WriteLine("1. isimi giriniz:  ");
string isim1 = Console.ReadLine();
Console.WriteLine("2. isimi giriniz:  ");
string isim2 = Console.ReadLine();

string yerdegisimi = isim1;
isim1 = isim2;
isim2 = yerdegisimi;

Console.WriteLine("Yer değiştirilmiş değerler:");
Console.WriteLine("\nBirinci isim: " + isim1);
Console.WriteLine("İkinci isim: " + isim2);

//
Console.WriteLine("\n-----------Cevap14---------");
Console.Write("Bir sayı giriniz: ");
if (int.TryParse(Console.ReadLine(), out int sayi14))
{
    bool answer = SayininTekMi(sayi14);
    Console.WriteLine($"Sayı tek mi? {answer}");
}
else
{
    Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir sayı giriniz.");
}    
    // Sayının tek mi yoksa çift mi olduğunu belirleyen metot
    static bool SayininTekMi(int sayi)
{
    return sayi % 2 != 0;
}

//Hız ve zamanın çarpını alarak gidilen mesafeyi hesaplıyoruz.
Console.WriteLine("\n-----------Cevap15---------");
static void yol(double hiz, double zaman)
{
    double yol = hiz * zaman;
    Console.WriteLine("Gidilen yol :" + yol + "km");
}
Console.Write("\nLütfen hızı giriniz(km/s) :");
double hiz = Convert.ToDouble(Console.ReadLine());
Console.Write("Lütfen zamanı giriniz(saat) :");
double zaman = Convert.ToDouble(Console.ReadLine());

yol(hiz,zaman);

// Dairenin alanını hesaplayan metodu yazdırıyoruz.
Console.WriteLine("\n-----------Cevap16---------");
static double HesaplaDaireAlan(double yaricap)
{
    // Alan hesaplaması: π * r^2
    double alan = Math.PI * Math.Pow(yaricap, 2);
    return alan;
}
    Console.Write("Dairenin yarıçapını girin: ");
    double yaricap = Convert.ToDouble(Console.ReadLine());
    double alan = HesaplaDaireAlan(yaricap);
    Console.WriteLine($"Dairenin alanı: {alan}");


//ToUpper ve ToLower ile yazıyı büyü ve küçük harflerle yazdırıyoruz.
Console.WriteLine("\n-----------Cevap17---------");
string metin17 = "Zaman bir GeRi SayIm";
Console.WriteLine(metin17.ToUpper());
Console.WriteLine(metin17.ToLower());

//Trim() ile text içindeki boşluklar gidireliyor.
Console.WriteLine("\n-----------Cevap18---------");
string text = "   Selamlar    ";
string trimmedText = text.Trim();
Console.WriteLine(trimmedText);