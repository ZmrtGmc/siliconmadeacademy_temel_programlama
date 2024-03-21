namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)//Zümrüt Gemici SiliconAkademi Görev2
        {
            // ürün fiyatı:100tl ve üzeri ise kargo bedeva 
            // kargo 5tl
            // ürünün fiyatı girildiğinde toplam ödenmeis gerekn tutarı göster c#
              int kargo = 5;
              Console.Write("Ürünün Fiyatını Giriniz:");
              int price=int.Parse(Console.ReadLine());
              if (price >= 100)
              {
                  //kargo bedava
                  Console.WriteLine("Toplam Ödenmesi Gereken Tutar (Kargo Bedava): " + price);
              }
              else
              {
                  //kargo ücreti ekle
                  Console.WriteLine("Toplam Ödenmesi Gereken Tutar Kargo ile: " + (price+kargo));
              }


              ///////////////////////////////////////////////////////////////////////////////////////////////

              // klavyeden iki ürün girilecek toplamları 200tl fazla ise;
              // 2.üründe %25 indirim yaparak ödeencek tutarı göster c#
              Console.Write("1.Ürünün Fiyatını Giriniz:");
              double x = double.Parse(Console.ReadLine());
              Console.Write("2.Ürünün Fiyatını Giriniz:");
              double y = double.Parse(Console.ReadLine());

              double toplam = x + y;
              if (toplam > 200)
              {
                  //2.üründe %25 indirim olur
                  double discount = y * 0.25;
                  double discount_price = y - discount;
                  Console.WriteLine("Girilen Ürünlerin Toplam Ödemesi: " + (x+discount_price));
              }
              else
              {
                  //normal ücret ekrana yazılır
                  Console.WriteLine("Girilen Ürünlerin Toplam Ödemesi: " + toplam);
              }

            ///////////////////////////////////////////////////////////////////////////////////////////////
            
            //1 den 25 e kadar olan sayıların karelerinin toplamını bulan c#
            int toplam1 =0;
              for(int i = 1; i <= 25; i++)
              {
                  toplam1 = toplam1 + (i * i);
              }
              Console.WriteLine("1'den 25'e kadar olan sayılarının karelerinin toplamı: " + toplam1);
            
            //kullanıcıdan kaç sayı girileceği sorulan ve ardından 
            int cift = 0, tek = 0, en_buyuk=0, en_kucuk=0;
            Console.Write("Sayı Adedi Giriniz: ");
            int zg = int.Parse(Console.ReadLine());
            for(int i = 1; i <= zg; i++)
            {
                Console.Write(i + ". Sayıyı Giriniz: ");
                int sayi=int.Parse(Console.ReadLine());
                if(sayi % 2 == 0)
                {
                    //çift sayi
                    cift++;
                }
                else
                {
                    //tek sayi
                    tek++;
                }
                // büyük sayi-küçük sayi
                if(i == 1 || sayi > en_buyuk)
                {
                    en_buyuk = sayi;
                }
                if (i == 1 || sayi < en_kucuk)
                {
                    en_kucuk = sayi;
                }
            }
            Console.WriteLine("Tek sayı adedi: " + tek);
            Console.WriteLine("Çift sayı adedi: " + cift);
            Console.WriteLine("En büyük sayı: " + en_buyuk);
            Console.WriteLine("En küçük sayı: " + en_kucuk);


            ///////////////////////////////////////////////////////////////////////////////////////////////

            //kullanıcıdan 2 sayı istenecek
            //bu sayıların arasındaki sayıların 3 ile tam olarak bölünebilen sayıların
            //ortamasını ve bu sayıların kaç tane olduğunu veren c# 
            int adet = 0;
            double toplam2=0;

            Console.Write("Başlangınç Sayısını Giriniz: ");
            double x1= double.Parse(Console.ReadLine());
            Console.Write("Bitiş Sayısını Giriniz: ");
            double y1 = double.Parse(Console.ReadLine());

            for(double i = x1; i <= y1; i++)
            {
                if (i % 3 == 0)
                {
                    toplam2 = toplam2 + i;
                    adet++;
                }
            }
            Console.WriteLine("Aralarındaki sayıların 3 ile tam bölünen sayı adedi: " + adet);
            Console.WriteLine("Aradaki sayıların 3 ile tam bölünen sayıların ortamalası: " + (toplam / adet));



            ///////////////////////////////////////////////////////////////////////////////////////////////

            //furkan, bir romanın her gün bir önceki gün okuduğu sayfadan 5 sayfa fazla okuyor
            //1. gün : 10 sayfa başlyana furkan
            //1000 sayfalık bir romanı kaç günde bitireceğini bulan program c#


            //örneğin ; 1.gün:10 sayfa , 2.gün: 15 sayfa olacak 1000 sayfaya ulaştığında kitap bitecek
            int sum_page = 1000; //toplam sayfa sayısı
            int read_page = 10; //ilk gün okunan sayfa sayısı
            int day = 1; //başlangıç günü
            while (read_page < sum_page)
            {
                read_page = read_page + 5;
                day++;
            }
            Console.WriteLine("Romanı bitirmek için gün sayısı: " + day);



            ///////////////////////////////////////////////////////////////////////////////////////////////


            //girilen sayının asal olup olmadığını söyleyen c# uygulaması
            //Asal sayılar, yalnızca kendisi ve 1'e bölünebilen, 1'den büyük doğal sayılardır.
            int sayi_bol =0;
            Console.Write("Sayı Giriniz: ");
            int x3=int.Parse(Console.ReadLine());
            if (x <= 1)
            {
                Console.WriteLine(x3 + " bir asal sayı DEĞİLDİR.");
            }
            for(int i = 2; i < x3; i++)
            {
                if (x3 % i == 0)
                {
                    sayi_bol++;
                }
            }
            if (sayi_bol == 0)
            {
                Console.WriteLine(x3 + " bir ASAL Sayıdır.");
            }
            else
            {
                Console.WriteLine(x3 + " bir asal sayı DEĞİLDİR.");
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //bir memur, ATM den para çekmek istemektedir.
            //makinede sadece 10,20,50 ve100tl banknotlar kalmıştır
            //Büyük değerli banknotların sayısı maksimum olacak şekilde,
            //çekilecek paranın kaç tane 100, 50, 20 ve 10 liralık
            //banknottan oluşacağını ekranda yazan C# yapın.

            int para, yuz_adet, elli_adet, yirmi_adet, on_adet;
            do
            {
                Console.Write("Lütfen para miktarını giriniz:");
                para = int.Parse(Console.ReadLine());
                if (para % 10 != 0)
                {
                    Console.WriteLine("Lütfen 10'un katları olan bir tutar girin.");
                }               
            } while (para % 10 != 0);

            yuz_adet = para / 100;
            para = para % 100; //çekilecek tutarın içindeki 100tl
                               //banknıotların sayısını ve kalan tutarı güncelleme işlemi
            elli_adet = para / 50;
            para=para % 50;//aynı işlem

            yirmi_adet = para / 20;
            para = para % 20;//aynı işlem

            on_adet = para / 10;
            para = para % 10; //aynı işlem

            Console.WriteLine("Çekilen banknotlar:");
            Console.WriteLine("100 TL: " + yuz_adet + " adet");
            Console.WriteLine("50 TL: " + elli_adet + " adet");
            Console.WriteLine("20 TL: " + yirmi_adet + " adet");
            Console.WriteLine("10 TL: " + on_adet + " adet");



            ///////////////////////////////////////////////////////////////////////////////////////////////


            //1'den 999'a kadar olan tam sayılar içerisinden basamaklarının küp değeri
            //toplamı kendisine eşit olan değerleri ekrana yazdıran C#
            Console.WriteLine("Basamaklarının küp değeri toplamı kendisine eşit olan sayılar:");
            for (int sayi = 1; sayi < 1000; sayi++)
            {
                int top = 0;
                int temp = sayi;//değer döngü içinde değişeceği için başka değişkene atıyoruz
                while (temp != 0)//sıfır olana kadar çalışır
                {
                    int basamak = temp % 10;//gecicinin son basamağı atanır
                    top = top + (basamak * basamak * basamak);//küpünü istediği için
                    temp = temp / 10;//bir sonraki basamağa geçmek için 10a bölünür
                }
                if (top == sayi)//toplam ve kontrol edilen sayı birbirine eşitse ekrana yazdırır
                {
                    Console.WriteLine(sayi);
                }
            }
        }
    }
}
