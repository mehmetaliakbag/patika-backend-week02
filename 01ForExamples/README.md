# C# Döngü ve Koşul Örnekleri

Bu proje, C# dilinde döngü ve koşul yapılarının nasıl kullanılacağını gösteren temel bir uygulamadır. Aşağıda çeşitli döngü örnekleri ve bunların çıktıları bulunmaktadır.

## İçindekiler

1. [Kendime İnanç Mesajı](#kendime-inanç-mesajı)
2. [1'den 20'ye Kadar Sayılar](#1den-20ye-kadar-sayılar)
3. [1'den 20'ye Kadar Çift Sayılar](#1den-20ye-kadar-çift-sayılar)
4. [50 ile 150 Arasındaki Sayıların Toplamı](#50-ile-150-arasındaki-sayıların-toplamı)
5. [1 ile 120 Arasındaki Çift ve Tek Sayıların Toplamı](#1-ile-120-arasındaki-çift-ve-tek-sayıların-toplamı)

## Kullanım

### Kendime İnanç Mesajı

Program, "Kendime inanıyorum, ben bu yazılım işini hallederim!" mesajını 10 kere konsola yazdırır.

```csharp
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} - Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
```

1'den 20'ye Kadar Sayılar
Program, 1'den 20'ye kadar olan sayıları konsola yazdırır.

```csharp
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}
```

1'den 20'ye Kadar Çift Sayılar
Program, 1'den 20'ye kadar olan çift sayıları konsola yazdırır.

```csharp
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
```

50 ile 150 Arasındaki Sayıların Toplamı
Program, 50 ile 150 arasındaki sayıların toplamını hesaplar ve konsola yazdırır.

```csharp
int total = 0;

for (int i = 50; i <= 150; i++)
{
    total += i;
}

Console.WriteLine($"50 - 150 arası sayıların toplamı: {total}");
```

1 ile 120 Arasındaki Çift ve Tek Sayıların Toplamı
Program, 1 ile 120 arasındaki çift ve tek sayıların toplamını hesaplar ve konsola yazdırır.

```csharp
int doubleTotal = 0;
int singleTotal = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        doubleTotal += i;
    }
    else
    {
        singleTotal += i;
    }
}

Console.WriteLine($"1 - 120 arasındaki çift sayıların toplamı: {doubleTotal}" +
                  $"\n1 - 120 arasındaki tek sayıların toplamı: {singleTotal}");
```

### Çıktılar
Yukarıdaki kodların çıktıları konsolda sırasıyla aşağıdaki gibi olacaktır:

Kendime inanıyorum mesajı 10 kere.

1'den 20'ye kadar sayılar.

1'den 20'ye kadar çift sayılar.

50 ile 150 arasındaki sayıların toplamı.

1 ile 120 arasındaki çift ve tek sayıların toplamı.

#### Geliştirme Ortamı

Dil: C#

IDE: Visual Studio veya benzeri bir IDE

##### Lisans
```css
Bu proje MIT Lisansı altında lisanslanmıştır. Detaylar için lütfen LICENSE dosyasına bakın.
```
