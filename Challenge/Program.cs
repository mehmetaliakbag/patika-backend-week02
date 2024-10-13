/*
 * 1 - Aşağıdaki çıktıyı yazan bir program.
 * Merhaba
 * Nasılsın ?
 * İyiyim
 * Sen nasılsın ?
 */

//Console.WriteLine("Merhaba" +
//                  "\r\nNaılsın ?" +
//                  "\r\nİyiyim" +
//                  "\r\nSen Nasılsın ?");

// -----------------------------------------------------------------------------------------------------------------------------------------

//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

//Console.Write("Bir sayı girin: ");
//int numberValue = Convert.ToInt32(Console.ReadLine());

//Console.Write("Bir harf, kelime veya cümle girin: ");
//string textValue = Console.ReadLine();

//Console.WriteLine($"Sayısal değer: {numberValue}" +
//                  $"\r\nMetinsel değer: {textValue}");

// -----------------------------------------------------------------------------------------------------------------------------------------

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.

//Random random = new Random();
//int randomNumber = random.Next();
//Console.WriteLine($"Random sayı: {randomNumber}");

// -----------------------------------------------------------------------------------------------------------------------------------------

//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

//Random random = new Random();
//int randomNumber = random.Next();
//int remainder = randomNumber % 3;

//Console.WriteLine($"Random sayının 3 ile bölümünden kalan: {remainder}");

// -----------------------------------------------------------------------------------------------------------------------------------------

//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama. ===> 18 yaşında olursa ne yapılacak belirtilmemeiş

//Console.Write("Yaşınız: ");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(age < 18 ? "-" : "+");

// -----------------------------------------------------------------------------------------------------------------------------------------

//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
//}

// -----------------------------------------------------------------------------------------------------------------------------------------

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

//Console.Write("Bir araba markası belirtin: ");
//string brand1 = Console.ReadLine();

//Console.Write("Bir araba markası belirtin: ");
//string brand2 = Console.ReadLine();


//Console.WriteLine("Değişim öncesi" +
//                  $"\r\nMarka1: {brand1}" +
//                  $"\r\nMarka2: {brand2}");

//string temp = brand1;
//brand1 = brand2;
//brand2 = temp;

//Console.WriteLine("Değişim sonrası" +
//                  $"\r\nMarka1: {brand1}" +
//                  $"\r\nMarka2: {brand2}");

// -----------------------------------------------------------------------------------------------------------------------------------------

//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

//void BenDegerDondurmem()
//{
//    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
//}

//BenDegerDondurmem();

// -----------------------------------------------------------------------------------------------------------------------------------------

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

//int CalculateTotal(int num1, int num2)
//{
//    return num1 + num2;
//}

//int total = CalculateTotal(7, 3);
//Console.WriteLine($"Toplam: {total}");

// -----------------------------------------------------------------------------------------------------------------------------------------

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

//string SendMessage(Boolean logical)
//{
//    string message;

//    if (logical == true)
//        message = "Naber Müdür";
//    else
//        message = "Şuan meşgulüm, byeee";

//    return message;
//}

//string message = SendMessage(true);

//Console.WriteLine($"Mesaj: {message}");

// -----------------------------------------------------------------------------------------------------------------------------------------

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

//int CalculateTheOldest(int age1, int age2, int age3)
//{
//    int theOldest;

//    if (age1 > age2 && age1 > age3)
//        theOldest = age1;
//    else if (age2 > age1 && age2 > age3)
//        theOldest = age2;
//    else
//        theOldest = age3;

//    return theOldest;
//}

//int oldest = CalculateTheOldest(51, 53, 99);
//Console.WriteLine($"En büyük yaş: {oldest}");

// -----------------------------------------------------------------------------------------------------------------------------------------

//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

//int CalculateTheLargestNumber(params int[] numbers)
//{
//    return numbers.Max();
//}

//int LargestNum = CalculateTheLargestNumber(51, 4, 1, 9, 151, 55, 444, 1001);
//Console.WriteLine($"En büyük sayı: {LargestNum}");

// -----------------------------------------------------------------------------------------------------------------------------------------

//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
//void Change(string text1, string text2)
//{
//    string temp = text1; text1 = text2; text2 = temp;

//    Console.WriteLine("Değişim" +
//                  $"\r\nText1: {text1}" +
//                  $"\r\nText2: {text2}");
//}

//Change("abc", "123");

// -----------------------------------------------------------------------------------------------------------------------------------------

//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

//bool SingleOrDouble(int num)
//{
//    if (num % 2 == 0 || num == 0)
//        return true;
//    else
//        return false;
//}

//bool result = SingleOrDouble(3);
//Console.WriteLine(result);

// -----------------------------------------------------------------------------------------------------------------------------------------

//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

//void CalculateDistance(int speed, int timeMin)
//{
//    double distance = (int)(speed * timeMin) / 60;
//    Console.WriteLine($"Alınan mesafe: {distance}");
//}

//CalculateDistance(80, 145);

// -----------------------------------------------------------------------------------------------------------------------------------------

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

//void CalculateAreaOfTheCircle(double radius)
//{
//    double area =Math.PI * (radius * radius);
//    Console.WriteLine($"Dairenin alanı: {area}");
//}

//CalculateAreaOfTheCircle(7);

// -----------------------------------------------------------------------------------------------------------------------------------------

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

//void printUpperAndLower()
//{
//    string message = "Zaman bir GeRi SayIm";
//    Console.WriteLine(message.ToLower());
//    Console.WriteLine(message.ToUpper());
//}

//printUpperAndLower();

// -----------------------------------------------------------------------------------------------------------------------------------------

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak. 

//string text = "    Selamlar   ";

//string trimText = text.Trim();
//Console.WriteLine(trimText);