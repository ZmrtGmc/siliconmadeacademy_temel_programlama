namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            /*10 dan 1e kadar olan sayıların alt altta ekrana yazdıran kodu yazın.
            int x = 10;
            while(x>0)
            {
                Console.WriteLine(x);
                x--;
            }

            //10 dan 1 e kadar sayıları yan yana ve araların boşluk koyarak ekrana yazıdran kodunu yazın
            int x = 10;
            while (x > 0)
            {
                Console.Write(x+" ");
                x--;
            }
            
            //0 ile 100 arasındaki while döngüsü ile toplayan ve bu değeri ekrana yazdıran kodu yazın
            int x = 0, toplam=0;
            while(x<=100)
            {
                toplam = x + toplam;
                x++;
            }
            Console.WriteLine("Toplam: " + toplam);
            
            //0 ile 100 arasındaki tek sayıları toplayarak sonucu ekrana yazdıran while döngüsü
            int x = 0, toplam = 0;
            while (x <= 100)
            {
                if (x % 2 != 0)
                {
                    toplam = x + toplam;
                }
                x++;
            }
            Console.WriteLine("Toplam: " + toplam);

            */

            //Kullancının girdiği sayı 0 olana kadar tekrar tekrar
            //kullanıcıdan sayi girişi alan programın kodunu while döngüsü kullanarak yazın
            /*int x = 1;
            while(x!=0)
            {
                Console.Write("Sayı Giriniz:");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sıfır Giremezsiniz.");
            */

            /*do while ile yapımı*/
            /*kodun en az bir kere çalışmasını istiyorsak bu yapı daha aktif kullanılır.)*/
            /* int x;
             do
             {
                 Console.Write("Sayı Giriniz:");
                 x = int.Parse(Console.ReadLine());
             } while (x != 0);*/

            /*
            //kullanıcın girdipi sayıların toplmaı 100 den küçük olduğu sürece 
            //kullanıcıdan sayı istemeye devam eden kodu do-while döngüsü kullanrak yazın
            //sonunda sayıların toplamanı ekrana yaz
            //kaç kere deneme yapıldığını ekrana yaz
            int x, toplam=0,sayac=0;
            do
            {
                Console.Write("Sayı Giriniz:");
                x = int.Parse(Console.ReadLine());
                toplam = toplam + x;
                sayac++;
            } 
            while (toplam < 100);
            Console.WriteLine("Girilen Sayıların Toplamı: " + toplam);
            Console.WriteLine("Toplam Yapılan Deneme: " + sayac);
           
            



            //önceden sabit olarak girilmiş bir sayıyı, kullanıcın kaç kerede tahmin ettiğini 
            //gösteren tahmin oyununun kodunu yazın, her sayı isteildiğinde kaçıncı sayısı istediğini de yazsın

            int zmrt = 8, x=0, sayac = 0;
            do
            {
                if (sayac < 7)
                {
                    sayac++;
                    Console.Write(sayac + " Sayı Giriniz:");
                    x = int.Parse(Console.ReadLine());
                    if (x > zmrt && sayac<7)
                    {
                        //sayi büyükse
                        Console.WriteLine("Daha küçük bir sayı giriniz.");
                    }
                    else if(x< zmrt && sayac < 7)
                    {
                        Console.WriteLine("Daha Büyük bir sayı giriniz.");
                    }
                }
                else
                {
                    Console.WriteLine("7 Tane Hakkınız Vardı. Maalesef Bulamadınız.");
                    break;
                }
            }
            while (x != zmrt);
            if (x == zmrt)
            {
                Console.WriteLine("Tebrikler");
                Console.WriteLine("Kaç Denemede Bulundu :" + sayac);
            }*/



        }
    }
}
