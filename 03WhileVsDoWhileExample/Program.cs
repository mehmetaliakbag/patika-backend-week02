// Kullanıcının girdiği bir limit değerine kadar konsol ekranına çıktı verir.

// While döngüsü
Console.Write("Bir sayı girin: ");
int limit1 = int.Parse(Console.ReadLine());
int counter1 = 0;

while (counter1 <= limit1)
{
    Console.WriteLine($"{counter1} - Ben bir Patika'lıyım");
    counter1++;
}

Console.WriteLine("\n----------------\n");


// Do-While döngüsü
Console.Write("Bir sayı girin: ");
int limit2 = int.Parse(Console.ReadLine());
int counter2 = 0;

do
{
    Console.WriteLine($"{counter2} - Ben bir Patika'lıyım");
    counter2++;
} while (counter2 <= limit2);

// Temel fark: While döngüsü koşul sağlanmazsa hiç çalışmaz. Do-while ise en az bir kez çalışır.