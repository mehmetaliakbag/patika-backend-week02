// 1 - "Kendime inanıyorum, ben bu yazılım işini hallederim" mesajını 10 kere konsola yazdırır
for (int i = 1; i <= 10; i++) // i 1'den başlayıp 10'a kadar gidecek
{
    Console.WriteLine($"{i} - Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine("\r\n----------------\r\n");

// 2 - 1'den 20'ye kadar olan sayıları konsola yazdırır
for (int i = 1; i <= 20; i++) // i 1'den 20'ye kadar döngü
{
    Console.WriteLine(i); // i değerini konsola yazdır
}

Console.WriteLine("\r\n----------------\r\n");

// 1'den 20'ye kadar olan çift sayıları konsola yazdırır
for (int i = 1; i <= 20; i++) // i 1'den 20'ye kadar döngü
{
    if (i % 2 == 0) // i çift ise
    {
        Console.WriteLine(i); // i değerini konsola yazdır
    }
}

Console.WriteLine("\r\n----------------\r\n");

// 4 - 50 ile 150 arasındaki sayıların toplamını hesaplar ve konsola yazdırır
int total = 0; // Toplamı tutmak için değişken

for (int i = 50; i <= 150; i++) // i 50'den 150'ye kadar döngü
{
    total += i; // i'yi toplam değişkenine ekle
}

// Toplamı konsola yazdır
Console.WriteLine($"50 - 150 arası sayıların toplamı: {total}");

Console.WriteLine("\r\n----------------\r\n");

// 5 - 1 ile 120 arasındaki çift ve tek sayıların toplamını hesaplar
int doubleTotal = 0; // Çift sayıların toplamı
int singleTotal = 0; // Tek sayıların toplamı

for (int i = 1; i <= 120; i++) // i 1'den 120'ye kadar döngü
{
    if (i % 2 == 0) // i çift ise
    {
        doubleTotal += i; // Çift sayıyı toplam değişkenine ekle
    }
    else // i tek ise
    {
        singleTotal += i; // Tek sayıyı toplam değişkenine ekle
    }
}

// Çift ve tek sayıların toplamlarını konsola yazdır
Console.WriteLine($"1 - 120 arasındaki çift sayıların toplamı: {doubleTotal}" +
                  $"\n1 - 120 arasındaki tek sayıların toplamı: {singleTotal}");


