string cevap;
do
{
    Random random = new Random();
    int bilgisayarSayisi = random.Next(1, 101);
    //Console.WriteLine("Bilgisayarın Tuttuğu Sayı : " + bilgisayarSayisi);

    int denemeSayisi = 0;

    Console.Write("Tahmininizi Girin : ");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    denemeSayisi++;

    while (tahmin != bilgisayarSayisi)
    {
        if (tahmin < bilgisayarSayisi)
        {
            Console.WriteLine("Daha büyük bir sayı deneyin.");
        }
        else
        {
            Console.WriteLine("Daha küçük bir sayı deneyin.");
        }

        Console.Write("Yeni Tahmininizi Girin : ");
        tahmin = Convert.ToInt32(Console.ReadLine());

        denemeSayisi++;

    }

    Console.WriteLine("Tebrikler, tahmininiz doğru!");
    Console.WriteLine($"{denemeSayisi}. denemede bildiniz.");

    Console.Write("Tekrar Oynamak İster Misiniz? (E/H) ");
    cevap = Console.ReadLine();
}

while (cevap.ToUpper() == "E");
