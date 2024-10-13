# Konsol Uygulaması: Temel Döngü İşlemleri

Bu uygulama, C# kullanarak çeşitli döngü işlemleri gerçekleştiren basit bir konsol uygulamasıdır. 

Kullanıcıya farklı görevler aracılığıyla temel döngü ve koşul yapıları hakkında bilgi vermeyi amaçlar.

## Kullanılan Teknolojiler

- **C#**
- **.NET (Konsol Uygulaması)**

## Görevler

Bu uygulama beş temel görev gerçekleştirmektedir:

### Görev 1: Motivasyon Mesajı

- "Kendime inanıyorum, ben bu yazılım işini hallederim!" mesajı 10 kere konsola yazdırılır.

### Görev 2: Sayı Yazdırma

- 1 ile 20 arasındaki sayılar konsola yazdırılır.

### Görev 3: Çift Sayı Yazdırma

- 1 ile 20 arasındaki çift sayılar konsola yazdırılır.

### Görev 4: Sayıların Toplamı

- 50 ile 150 arasındaki sayıların toplamı hesaplanır ve konsola yazdırılır.

### Görev 5: Tek ve Çift Sayıların Toplamı

- 1 ile 120 arasındaki tek ve çift sayıların toplamı hesaplanır ve konsola yazdırılır.

## Kod

Aşağıda uygulamanın temel kodu yer almaktadır:

1 - "Kendime inanıyorum, ben bu yazılım işini hallederim!" mesajını 10 kere konsola yazdırır
```csharp
int counter = 1; // Sayaç değişkeni

while (counter <= 10) // Sayaç 10'a kadar devam edecek
{
    Console.WriteLine($"{counter} - Kendime inanıyorum, ben bu yazılım işini hallederim!"); // Mesajı konsola yazdır
    counter++; // Sayacı bir artır
}
```

2 - 1 ile 20 arasındaki sayıları konsola yazdırır

```csharp
int counter1 = 1; // İkinci sayaç değişkeni

while (counter1 <= 20) // Sayaç 20'ye kadar devam edecek
{
    Console.WriteLine(counter1); // Sayıyı konsola yazdır
    counter1++; // Sayacı bir artır
}
```

3 - 1 ile 20 arasındaki çift sayıları konsola yazdırır

```csharp
int counter2 = 1; // Üçüncü sayaç değişkeni

while (counter2 <= 20) // Sayaç 20'ye kadar devam edecek
{
    if (counter2 % 2 == 0) // Eğer sayı çift ise
    {
        Console.WriteLine(counter2); // Çift sayıyı konsola yazdır
    }
    counter2++; // Sayacı bir artır
}
```

4 - 50 ile 150 arasındaki sayıların toplamını hesaplar ve konsola yazdırır

```csharp
int counter3 = 50; // Dördüncü sayaç değişkeni
int total = 0; // Toplamı tutan değişken

while (counter3 <= 150) // Sayaç 150'ye kadar devam edecek
{
    total += counter3; // Sayıyı toplam değişkenine ekle
    counter3++; // Sayacı bir artır
}

// Toplamı konsola yazdır
Console.WriteLine($"50 ile 150 arası sayıların toplamı: {total}");
```

5 - 1 ile 120 arasındaki tek ve çift sayıların toplamını hesaplar

```csharp
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
```

### Çalıştırma Talimatları

C# geliştirme ortamını (örneğin, Visual Studio veya Visual Studio Code) kurun.

Yukarıdaki kodu bir .cs dosyasına yapıştırın (örneğin DöngüUygulaması.cs).

Uygulamayı çalıştırarak görevleri görün.

#### İletişim

Herhangi bir soru veya geri dönüş için GitHub kullanıcı adım üzerinden iletişime geçebilirsiniz.

###### Lisans

```css
Bu proje MIT lisansı altındadır. İstediğiniz gibi kullanabilir ve dağıtabilirsiniz.
```