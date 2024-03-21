namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //28/02/2024 çarşamba günü
            //1.soru:
            /*
             * Console.WriteLine("-----");
             * Console.WriteLine("|000|");
             * Console.WriteLine("|000|");
             * Console.WriteLine("|000|");
             * Console.WriteLine("-----");
             * 

            for(int i=1; i <= 5; i++)//satırlar
            {
                for(int a = 1; a <= 5; a++)//sütunlar
                {
                    if(i==1 || i == 5)
                    {
                        Console.Write("");
                    }
                    else if(a==1 || a == 5)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }*/
            //2.soru:
            /*
             * *
             * **
             * ***
             * ****
             * ******
             * ******* ekran çıktısını oluşturan for döngüsünü yazın.
             * 
            string yildiz = "";
            for(int i = 1; i <= 9; i++)//satırlar
            {
                for(int a = 1; a <= i; a++)//sütunlar
                {
                    yildiz += "*";
                }
                Console.WriteLine(yildiz);
            }

            //3.soru 
            // yukarıdaki gibi yıldızlardan tam bir yıldız oluşturun.

            int satir = 5;
            for(int i = 1; i <= satir; i++)//satılrımız
            {
                for(int j = 1; j <= satir - i; j++)//yıldızların başlangıç pozisyonu lazım
                {
                    Console.Write(" ");//boşluk ekledim
                }
                for(int a = 1; a <= 2 * i-1; a++)//yildiz ekle
                {
                    Console.Write("*");
                }
                Console.WriteLine();//bir sonraki satır
            }*/

            //4.soru
            //klavyeden girilen bir sayının kaç basamaklı olduğuu söyleyen c# uygulamasını yazın.
            //1.yol: 
            Console.Write("Sayı Giriniz: ");
            int x=int.Parse(Console.ReadLine());

            int number = 0;
            while (x != 0)
            {
                x /= 10;
                number++;
            }
            Console.WriteLine("Girilen sayı "+number+" basamaklıdır.");

            //2.yol:
            Console.Write("Sayı Giriniz: ");
            string z = Console.ReadLine();;
            int zmrt = z.Length;
            Console.WriteLine(zmrt);

        }
    }
}
