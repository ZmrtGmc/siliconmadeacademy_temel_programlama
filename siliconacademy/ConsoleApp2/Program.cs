namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for döngüsü
            /* for(int adet=0; adet < 5; adet++)
             {
                 Console.WriteLine("Merhaba Zmrt");
             }*/


            //1. soru 20den 1 e kadar oaln sayıları alt altta ekrana yazdıran kod
            /*for (int x = 20; x >= 1; x--)
            {
                Console.WriteLine(x);
            }

            //2.soru: 
            //20 den 1 e kadar sayıları yan yana ve aralarında virgül işartiyle koyarak ekrana yazın
            for (int x = 20; x >= 1; x--)
            {
                if(x==1)
                {
                    Console.Write(x);
                }
                else
                {
                    Console.Write(x + ",");
                }          
            }

            //3.soru
            //0 ile 20(dahil) arasındaki çift sayıların toplayarak ekrana gösteren program
            //1.yöntem:
            int toplam = 0;
            for(int x = 0; x <= 20; x++)
            {
                if(x %2==0)
                {
                    toplam = toplam + x;
                }
            }
            Console.WriteLine(toplam);
            //2.yöntem
            for(int i = 20; i > 0; i = i - 2)
            {
                toplam = toplam + i;
            }
            Console.WriteLine(toplam);
            

            //4. soru
            // 1+4+9+....100=X 
            //yukarıdaki ifadeler yer alan sayı örtüsü anlaşılıp arada bulunann ve görünmeyen boşluklaru
            //sayıların da örnekte görüldüğü gibi yatay ve aralrında artı(+) olacak şekilde,
            //döngüler ile yazılması ve sonuna eşittir ifadesi (=) konması sağlanır.
            // görünen işlemin sonucu da X ifaseinin yerine yazılır.
            int toplam = 0;
            for(int i = 1; i <= 10; i++)
            {
                if(i<10)
                { 
                 Console.Write((i * i) + " + ");
                }
                else
                {
                    Console.Write((i * i) + " = ");
                }
                toplam = toplam + (i * i);
            }
            Console.WriteLine(toplam);

            */

            //5.soru
            //kullanıcın kaç tane sayı gireceğini isteyin
            //kullanıcın yazdığı adt kadar sayı girişi alın

            //bu sayıların kaç tanesi 50 den büyük olduğunu ekrana yazdırın
            // 50 den büyük sayıların ortamasını ekrana yazdırın.
            int toplam = 0, adet=0;

            Console.Write("Kaç adet sayı girilecek: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x; i++)
            {
                Console.Write(i+". Sayı Giriniz: ");
                int y=int.Parse(Console.ReadLine());
                if (y >= 50)
                {
                    toplam = toplam + y;
                    adet++;
                }
            }
            Console.WriteLine("50'den büyük "+adet+" tane sayı girildi. Bu sayıların ortalaması: "+(toplam/adet));



        }
    }
}
