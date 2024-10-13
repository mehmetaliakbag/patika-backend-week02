// Task 1: "Kendime inanıyorum, ben bu yazılım işini hallederim!" mesajını 10 kere konsola yazdırır
int counter = 1; // Sayaç değişkeni

while (counter <= 10) // Sayaç 10'a kadar devam edecek
{
    Console.WriteLine($"{counter} - Kendime inanıyorum, ben bu yazılım işini hallederim!"); // Mesajı konsola yazdır
    counter++; // Sayacı bir artır
}

Console.WriteLine("\r\n------------------\r\n");

// Task 2: 1 ile 20 arasındaki sayıları konsola yazdırır
int counter1 = 1; // İkinci sayaç değişkeni

while (counter1 <= 20) // Sayaç 20'ye kadar devam edecek
{
    Console.WriteLine(counter1); // Sayıyı konsola yazdır
    counter1++; // Sayacı bir artır
}

Console.WriteLine("\r\n------------------\r\n");

// Task 3: 1 ile 20 arasındaki çift sayıları konsola yazdırır
int counter2 = 1; // Üçüncü sayaç değişkeni

while (counter2 <= 20) // Sayaç 20'ye kadar devam edecek
{
    if (counter2 % 2 == 0) // Eğer sayı çift ise
    {
        Console.WriteLine(counter2); // Çift sayıyı konsola yazdır
    }
    counter2++; // Sayacı bir artır
}

Console.WriteLine("\r\n------------------\r\n");

// Task 4: 50 ile 150 arasındaki sayıların toplamını hesaplar ve konsola yazdırır
int counter3 = 50; // Dördüncü sayaç değişkeni
int total = 0; // Toplamı tutan değişken

while (counter3 <= 150) // Sayaç 150'ye kadar devam edecek
{
    total += counter3; // Sayıyı toplam değişkenine ekle
    counter3++; // Sayacı bir artır
}

// Toplamı konsola yazdır
Console.WriteLine($"50 ile 150 arası sayıların toplamı: {total}");

Console.WriteLine("\r\n------------------\r\n");

// Task 5: 1 ile 120 arasındaki tek ve çift sayıların toplamını hesaplar
int counter4 = 1; // Beşinci sayaç değişkeni
int doubleTotal = 0; // Çift sayıların toplamı
int singleTotal = 0; // Tek sayıların toplamı

while (counter4 <= 120) // Sayaç 120'ye kadar devam edecek
{
    if (counter4 % 2 == 0) // Eğer sayı çift ise
    {
        doubleTotal += counter4; // Çift sayıyı toplam değişkenine ekle
    }
    else // Eğer sayı tek ise
    {
        singleTotal += counter4; // Tek sayıyı toplam değişkenine ekle
    }

    counter4++; // Sayacı bir artır
}

// Çift ve tek sayıların toplamlarını konsola yazdır
Console.WriteLine($"1 ile 120 arası çift sayıların toplamı: {doubleTotal}" +
                  $"\n1 ile 120 arası tek sayıların toplamı: {singleTotal}");