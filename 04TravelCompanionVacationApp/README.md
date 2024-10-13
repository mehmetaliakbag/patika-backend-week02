# Tatil Planlama Uygulaması

Bu proje, kullanıcıların tatil planlamalarına yardımcı olmak için geliştirilmiş bir C# konsol uygulamasıdır. Kullanıcıdan tatil lokasyonu, kişi sayısı ve ulaşım tercihi gibi bilgileri alarak toplam tatil maliyetini hesaplar.

## İçindekiler

1. [Kullanım](#kullanım)
2. [Kod Açıklamaları](#kod-açıklamaları)
3. [Geliştirme Ortamı](#geliştirme-ortamı)
4. [Lisans](#lisans)

## Kullanım

Uygulama, kullanıcıdan aşağıdaki bilgileri alır:

1. **Tatil Lokasyonu:** Kullanıcı, Bodrum, Marmaris veya Çeşme seçeneklerinden birini seçer.
2. **Kişi Sayısı:** Kullanıcı, tatil planladığı kişi sayısını girer.
3. **Ulaşım Tercihi:** Kullanıcı, kara yolu veya hava yolu arasında bir seçim yapar.

Uygulama, kullanıcıdan aldığı bilgilere dayanarak toplam tatil maliyetini hesaplar ve ekrana yazdırır. Kullanıcı, başka bir tatil planlamak isteyip istemediğini belirtebilir.

## Kod Açıklamaları

Aşağıda uygulamanın ana kod parçaları ve işleyişi açıklanmaktadır:

### 1. Lokasyon Seçimi

Kullanıcıdan tatil için gitmek istediği lokasyonu seçmesi istenir. Seçeneklerden biri geçerli değilse, hata mesajı verilir ve kullanıcıdan tekrar denemesi istenir.

```csharp
while (!isValidLocation)
{
    // Kullanıcıdan lokasyon bilgisi alınır
}
```

### 2. Kişi Sayısı Girişi

Kullanıcıdan tatil planlanan kişi sayısı istenir. Geçersiz bir sayı girildiğinde hata mesajı verilir ve kullanıcıdan tekrar girmesi istenir.

```csharp
while (!isValidHeadCount)
{
    // Kullanıcıdan kişi sayısı bilgisi alınır
}
```

### 3. Ulaşım Tercihi Seçimi

Kullanıcıdan ulaşım aracını seçmesi istenir. Geçerli bir seçenek girilene kadar hata mesajı ile yönlendirilir.

```csharp
while (!isValidTransport)
{
    // Kullanıcıdan ulaşım tercihi bilgisi alınır
}
```

### 4. Toplam Maliyet Hesaplama

Seçilen lokasyon, ulaşım tercihi ve kişi sayısına göre toplam tatil maliyeti hesaplanır ve ekrana yazdırılır.

```csharp
double totalCost = (locationPrice + transportCost) * headCount;
Console.WriteLine($"Toplam tatil maliyeti: {totalCost} TL");
```

### 5. Tekrar Planlama

Kullanıcıya başka bir tatil planlayıp planlamayacağı sorulur. Kullanıcı "Evet" derse program döngüye girer ve yeni bir planlama yapılır.

```csharp
do
{
    // Tatil planlaması döngüsü
} while (continuePlanning);
```

##### Geliştirme Ortamı

Dil: C#

IDE: Visual Studio veya benzeri bir IDE

###### Lisans

```css
Bu proje MIT Lisansı altında lisanslanmıştır. Detaylar için lütfen LICENSE dosyasına bakın.
```