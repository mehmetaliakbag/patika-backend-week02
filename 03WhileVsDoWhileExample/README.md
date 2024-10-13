# C# Döngü Örnekleri: While ve Do-While

Bu proje, C# dilinde `while` ve `do-while` döngülerinin nasıl kullanılacağını gösteren temel bir uygulamadır. Kullanıcının girdiği bir limit değerine kadar konsol ekranına belirli bir mesajı yazdırır.

## İçindekiler

1. [While Döngüsü](#while-döngüsü)
2. [Do-While Döngüsü](#do-while-döngüsü)
3. [Temel Farklar](#temel-farklar)

## Kullanım

### While Döngüsü

Program, kullanıcının girdiği bir limit değerine kadar `while` döngüsü ile "Ben bir Patika'lıyım" mesajını konsola yazdırır.

```csharp
Console.Write("Bir sayı girin: ");
int limit1 = int.Parse(Console.ReadLine());
int counter1 = 0;

while (counter1 <= limit1)
{
    Console.WriteLine($"{counter1} - Ben bir Patika'lıyım");
    counter1++;
}
```

### Do-While Döngüsü

Program, kullanıcının girdiği bir limit değerine kadar do-while döngüsü ile "Ben bir Patika'lıyım" mesajını konsola yazdırır. do-while döngüsü, en az bir kez çalıştığı için başlangıçta kullanıcıdan alınan sayıyı kontrol etmeden mesajı ekrana yazdırır.

```csharp
Console.Write("Bir sayı girin: ");
int limit2 = int.Parse(Console.ReadLine());
int counter2 = 0;

do
{
    Console.WriteLine($"{counter2} - Ben bir Patika'lıyım");
    counter2++;
} while (counter2 <= limit2);
```

#### Temel Farklar

##### While Döngüsü:

Koşul sağlanmadığı sürece döngü çalışmaz. Eğer koşul baştan sağlanmazsa, döngü hiç çalışmaz.

##### Do-While Döngüsü:

Koşulun sağlanıp sağlanmadığına bakılmaksızın, döngü en az bir kez çalışır. İlk çalışmada koşul kontrol edilmez.

### Geliştirme Ortamı
Dil: C#

IDE: Visual Studio veya benzeri bir IDE

###### Lisans

```css
Bu proje MIT Lisansı altında lisanslanmıştır. Detaylar için lütfen LICENSE dosyasına bakın.
```