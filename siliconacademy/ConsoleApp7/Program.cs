namespace ConsoleApp7
{
    internal class Program//Zümrüt Gemici
    {

        static Sinema Snm; //oluşturudğumuz classa ulşabilmek için tanımlama yapıyoruz
        static void Main(string[] args)
        {
            Uygulama();
        }
        static string SecimAl()
        {
            // kullanıcının yaptığı seçimi almak için bu metodu oluşturduk

            string karakterler = "1234SRDX";
            int sayac = 0;

            while (true)
            {
                sayac++;
                Console.Write("Seçiminiz : ");
                string giris = Console.ReadLine().ToUpper();
                int index = karakterler.IndexOf(giris);

                Console.WriteLine();

                if (giris.Length == 1 && index >= 0)
                {
                    return giris;
                }

                else
                {
                    if (sayac == 10)
                    {
                        Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                        Environment.Exit(0);
                    }


                    Console.WriteLine("Hatalı giriş yapıldı.");
                }
                Console.WriteLine();
            }
        }

        static void Uygulama()
        {
            Kurulum();
            Menu();
            Console.WriteLine();
            while (true)
            {
                string secim = SecimAl();
                switch (secim)
                {
                    case "1":
                    case "S":
                        BiletSat();
                        break;
                    case "2":
                    case "R":
                        BiletIade();
                        break;
                    case "3":
                    case "D":
                        DurumBilgisi();
                        break;
                    case "4":
                    case "X":
                        //Çıkış
                        break;
                }
                Console.WriteLine();
            }
        }
        static void BiletIade()
        {
            Console.WriteLine("Bilet İade");
            Console.Write("Tam Bilet İade Adedi: ");
            int tam = int.Parse(Console.ReadLine());

            Console.WriteLine("Yarım Bilet İade Adedi: ");
            int yarim = int.Parse(Console.ReadLine());

            Snm.Biletİade(tam, yarim);//class da oluşturduğumuz metodumuza atama yapıldı
        }
        static void DurumBilgisi()
        {
            Console.WriteLine("Durum Bilgisi");
            Console.WriteLine("Film: " + Snm.FilmAdı);
            Console.WriteLine("Kapasite: " + Snm.Kapasite);
            Console.WriteLine("Tam Bilet Fiyatı: " + Snm.TamBiletFiyati);
            Console.WriteLine("Yarım Bilet Fiyatı: " + Snm.YarimBiletFiyati);
            Console.WriteLine("Toplam Tam Bilet Adedi: " + Snm.ToplamTamBiletAdedi);
            Console.WriteLine("Toplam Yarim Bilet Adedi: " + Snm.ToplamYarıimBiletAdeti);
            Console.WriteLine("Ciro: " + Snm.Ciro);

        }
        static void BiletSat()
        {
            Console.WriteLine("Bilet Sat");
            Console.Write("Tam Bilet Adedi: ");
            int tam=int.Parse(Console.ReadLine());

            Console.WriteLine("Yarım Bilet Adedi: ");
            int yarim=int.Parse(Console.ReadLine());

            Snm.BiletSatisi(tam, yarim);//class da oluşturduğumuz metodumuza atama yapıldı
        }

        static void Kurulum()
        {
            Console.WriteLine("----------Butik Sinema Salonu-----------");
            Console.Write("Film Adı: ");
            string film = Console.ReadLine();

            Console.Write("Kapasite: ");
            int kapasite=int.Parse(Console.ReadLine());

            Console.Write("Tam Bilet Fiyati: ");
            int tam=int.Parse(Console.ReadLine());

            Console.Write("Tam Bilet Fiyati: ");
            int yarim = int.Parse(Console.ReadLine());

            Snm = new Sinema(film, kapasite, tam, yarim);

            Console.WriteLine();

        }
        static void Menu()
        {
            Console.WriteLine("1- Bilet Sat(s)  ");
            Console.WriteLine("2- Bilet İade(R) ");
            Console.WriteLine("3- Durum Bilgisi(D)  ");
            Console.WriteLine("4- Çıkış(X) ");
            Console.WriteLine();
        }
    }
}
