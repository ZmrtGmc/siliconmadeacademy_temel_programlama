using System;
using System.Collections.Generic;

namespace OgrenciYonetimUygulamasi
{
    class Program
    {
        //Zümrüt Gemicii

        static List<Ogrenci> ogrenciler = new List<Ogrenci>(); //ogrenciler kısmını istediğimzi gibi değiştirebiliriz

        static void Main(string[] args)
        {
            Uygulama();
        }

        static string SecimAl()
        {
            for (int i = 0; i < 10; i++) // Kullanıcının en fazla 10 kez deneme hakkı var.
            {
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine().Trim().ToUpper(); // Kullanıcı girişini alırken baştaki ve sondaki boşlukları temizler, küçük harfe çevirir.
                if (secim == "L" || secim == "S" || secim == "E" || secim == "1" || secim == "2" || secim == "3" || secim == "4") // Kullanıcının girmesi gereken geçerli seçenekler buraya eklenir.
                {
                    return secim; // Geçerli bir seçim yapıldığında seçimi döndürür.
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yapıldı.");
                }
            }
            Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
            Environment.Exit(0); // Programı sonlandırır.
            return null; // Gereksiz, çünkü Environment.Exit() programı sonlandıracaktır, bu yüzden bu satıra hiçbir zaman ulaşılmaz.
        }

        static void Uygulama()
        {
            SahteVeriEkle();
            Menu();

            while (true)
            {
                string giris = SecimAl();//yapılan seçimi kontrol edip geri döndürüyor
                Console.WriteLine("Seçiminiz: " + giris);//yapılan doğru seçime göre işlem yapılıyor

                switch (giris)
                {
                    case "E":
                    case "1":
                        OgrenciEkle();//metoduna giderek gerekli işlemleri yapar
                        break;
                    case "L":
                    case "2":
                        OgrenciListele();
                        break;
                    case "S":
                    case "3":
                        OgrenciSil();
                        break;
                    case "4":
                    case "X":
                        // çıkış
                        Console.WriteLine("Programdan çıkılıyor...");
                        Environment.Exit(0);//breakla döngüler sonlandırılır ancak program tamamen kapatılmadığı için
                        //Environment.Exit(0) yöntemi, programın çıkış kodu olarak kullanarak program sonlandırılır.
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin :)");
                        break;
                }
                Console.WriteLine();
            }

        }

        static void OgrenciEkle()
        {
                Ogrenci o = new Ogrenci();

                Console.WriteLine("1- Öğrenci Ekle ----------");

                // Mevcut öğrenci sayısını alarak sıra numarasını belirliyoruz
                int siranumarasi = ogrenciler.Count + 1;
                Console.WriteLine(siranumarasi + ". Öğrencinin");//örneğin 4.Öğrenci şeklinde ekrana yazdırır

                bool numaraVar;
                do
                {
                    numaraVar = false; // Her döngü başında numaraVar'ı false olarak ayarlıyoruz

                    Console.Write("Öğrencinin No: ");
                    int numara = int.Parse(Console.ReadLine());

                    // Numaranın listede zaten var olup olmadığını kontrol ediyoruz
                    foreach (Ogrenci ogrenci in ogrenciler)
                    {
                        if (ogrenci.No == numara)
                        {
                            Console.WriteLine("Bu numara zaten mevcut. Lütfen farklı bir numara girin.");
                            numaraVar = true;
                            break;
                        }
                    }

                    if (!numaraVar)
                    {
                        o.No = numara;
                    }
                } while (numaraVar);

                Console.Write("Öğrencinin Adı: ");
                o.Ad = Console.ReadLine();
                Console.Write("Öğrencinin Soyadı: ");
                o.Soyad = Console.ReadLine();
                Console.Write("Öğrencinin Şubesi: ");
                o.Sube = Console.ReadLine();
                Console.WriteLine();

                // Kullanıcıya öğrencinin bilgilerini onaylaması için bir özet sunumu
                Console.WriteLine("Eklenen Öğrenci Bilgileri:");
                Console.WriteLine("No: " + o.No);
                Console.WriteLine("Adı: " + o.Ad);
                Console.WriteLine("Soyadı: " + o.Soyad);
                Console.WriteLine("Şube: " + o.Sube);

                Console.Write("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H) ");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "E")
                {
                    ogrenciler.Add(o);
                    Console.WriteLine("Öğrenci eklendi.");
                }
                else
                {
                    Console.WriteLine("Öğrenci eklenmedi.");
                }

                Console.WriteLine();
        }


        static void OgrenciListele()
        {
                Console.WriteLine("2- Öğrenci Listele-----------");

                if (ogrenciler.Count == 0)
                {
                    Console.WriteLine("Gösterilecek öğrenci yok.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Şube    No    Ad Soyad");
                    Console.WriteLine("----------------------------------");

                    foreach (Ogrenci item in ogrenciler)
                    {
                    /* string ad = char.ToUpper(item.Ad[0]) + item.Ad.Substring(1).ToLower(); // Adın ilk harfi büyük, diğer harfleri küçük olacak şekilde düzenlendi
                     string soyad = char.ToUpper(item.Soyad[0]) + item.Soyad.Substring(1).ToLower(); // Soyadın ilk harfi büyük, diğer harfleri küçük olacak şekilde düzenlendi
                   */
                    string adSoyad = char.ToUpper(item.Ad[0]) + item.Ad.Substring(1).ToLower() + " " + char.ToUpper(item.Soyad[0]) + item.Soyad.Substring(1).ToLower();
                    //ad soyad kısmını birleştirmem gerekiyordu diğer türlü hizalamak inanılmaz zorladı
                    Console.WriteLine(item.Sube.PadRight(8) + item.No.ToString().PadRight(4) + "  " + adSoyad);
                }
            }
        }

        static void OgrenciSil()
        {
            if (ogrenciler.Count == 0)//öğrenci sayımızı kontrol ediyoruz
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
                return;
            }

            Console.WriteLine("3- Öğrenci Sil ----------");
            Console.WriteLine("Silmek istediğiniz öğrencinin");
            Console.Write("No: ");
            int no = int.Parse(Console.ReadLine());

            Ogrenci ogr = null;

            foreach (Ogrenci item in ogrenciler)
            {
                if (item.No == no)
                {
                    ogr = item;
                    break;
                }
            }

            if (ogr != null)
            {
                Console.WriteLine("Adı : " + ogr.Ad);
                Console.WriteLine("Soyadı : " + ogr.Soyad);
                Console.WriteLine("Şubesi : " + ogr.Sube);
                Console.WriteLine();
                Console.Write("Öğrenciyi silmek istediğinize emin misiniz? (E/H) ");
                string secim = Console.ReadLine();

                if (secim == "E")//eğer E harfine basılırsa silme işlemi başarılı
                {
                    ogrenciler.Remove(ogr);
                    Console.WriteLine("Öğrenci silindi.");
                }
                else
                {
                    Console.WriteLine("Öğrenci silinmedi");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci bulunamadı.");//yazılan numaraya göre uygun veri yoksa bilgi mesajı
            }

    }


        static void Menu()
        {
            Console.WriteLine("Öğrenci Yönetim Uygulaması ");
            Console.WriteLine("1 - Öğrenci Ekle(E)        ");
            Console.WriteLine("2 - Öğrenci Listele(L)     ");
            Console.WriteLine("3 - Öğrenci Sil(S)         ");
            Console.WriteLine("4 - Çıkış(X)               ");
            Console.WriteLine();
        }

        static void SahteVeriEkle()
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "veli";
            o1.Soyad = "küçük";
            o1.No = 1;
            o1.Sube = "A";
            ogrenciler.Add(o1);

            Ogrenci o2 = new Ogrenci();
            o2.Ad = "ali";
            o2.Soyad = "yılmaz";
            o2.Sube = "B";
            o2.No = 2;
            ogrenciler.Add(o2);

            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Ayşe";
            o3.Soyad = "yıldız";
            o3.No = 3;
            o3.Sube = "C";
            ogrenciler.Add(o3);
        }

    }
}
