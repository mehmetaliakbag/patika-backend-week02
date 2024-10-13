bool continuePlanning; // Programın yeniden çalışıp çalışmayacağını belirten değişken

do
{
    string location = ""; // Lokasyon bilgisi
    int locationPrice = 0; // Lokasyon tatil paketi fiyatı
    bool isValidLocation = false; // Lokasyon geçerliliği için değişken

    while (!isValidLocation) // Geçerli bir lokasyon girilene kadar döngü devam eder
    {
        Console.Write("Tatil için nereye gitmek istersiniz?" +
                      "\r\nBodrum" +
                      "\r\nMarmaris" +
                      "\r\nÇeşme" +
                      "\r\n");

        location = Console.ReadLine().ToLower();

        // Lokasyona göre fiyat belirleme
        switch (location)
        {
            case "bodrum":
                locationPrice = 4000;
                isValidLocation = true; // Geçerli giriş
                break;
            case "marmaris":
                locationPrice = 3000;
                isValidLocation = true; // Geçerli giriş
                break;
            case "çeşme":
                locationPrice = 5000;
                isValidLocation = true; // Geçerli giriş
                break;
            default:
                Console.WriteLine("Hatalı giriş yaptınız, tekrar deneyin."); // Geçersiz giriş uyarısı
                break;
        }
    }

    int headCount = 0; // Kişi sayısı
    bool isValidHeadCount = false; // Kişi sayısının geçerliliği için değişken

    while (!isValidHeadCount)
    {
        Console.Write("Tatile kaç kişi çıkmayı planlıyorsunuz: ");
        bool isValidInput = int.TryParse(Console.ReadLine(), out headCount);

        if (headCount > 0)
            isValidHeadCount = true; // Geçerli bir sayı girildi
        else
            Console.WriteLine("Yanlış işlem yaptınız, tekrar deneyin."); // Geçersiz sayı uyarısı
    }

    string locationInfo = location;

    // Tatil beldesi hakkında bilgilendirme
    switch (locationInfo)
    {
        case "bodrum":
            locationInfo = "Bodrum, güzel plajları, tarihi kalıntıları ve hareketli gece hayatıyla ünlüdür.";
            break;

        case "marmaris":
            locationInfo = "Marmaris, doğal güzellikleri ve yemyeşil ormanları ile tanınır.";
            break;

        default:
            locationInfo = "Çeşme, sıcak plajları ve şifalı kaplıcalarıyla ünlüdür.";
            break;
    }

    Console.WriteLine(locationInfo); // Lokasyon bilgisini ekrana yazdır

    int transportChoice = 0; // Tercih edilen ulaşım yolu
    bool isValidTransport = false; // Ulaşım seçeneğinin geçerliliği için değişken

    while (!isValidTransport) // Geçerli bir ulaşım seçeneği girilene kadar döngü devam eder
    {
        Console.Write("Lütfen ulaşım aracı seçiniz: " +
                      "\r\n1 - Kara yolu (Kişi başı 1500 TL) " +
                      "\r\n2 - Hava yolu (Kişi başı 4000 TL)" +
                      "\r\n");
        bool isValidInput = int.TryParse(Console.ReadLine(), out transportChoice);

        // Seçenek geçerli ise döngü kırılır
        if (isValidInput && (transportChoice == 1 || transportChoice == 2))
            isValidTransport = true;
        else
            Console.WriteLine("Hatalı giriş yaptınız, tekrar deneyin."); // Geçersiz seçenek uyarısı
    }

    // Ulaşım maliyetini belirleme
    int transportCost = (transportChoice == 1) ? 1500 : 4000; // Kara yolu veya hava yolu

    double totalCost = (locationPrice + transportCost) * headCount; // Toplam maliyet hesaplama
    Console.WriteLine($"Toplam tatil maliyeti: {totalCost} TL"); // Toplam maliyeti ekrana yazdır

    Console.Write("Başka bir tatil planlamak ister misiniz? (Evet): ");
    string choose = Console.ReadLine().ToLower();

    // Kullanıcı yeni bir işlem yapmak isterse döngü baştan başlayacak
    continuePlanning = (choose == "evet");

} while (continuePlanning); // Kullanıcı devam etmek istiyorsa döngü devam eder

Console.WriteLine("İyi günler dileriz :)"); // Program sonu mesajı