namespace ConsoleApp6
{
    internal class Program//zümrüt gemici görev4 A-1 soru:
    {
        /*Math sınıfı metodlarından Math.Pow(2,3) metodu ile aynı işlevdeki kendi metodunuzu yazın.
         * (Bu metot pozitif integer değerler için çalışsın ve içinde hiçbir Math sınıfından metot kullanılmasın.)
         */
        static void Main(string[] args)
        {
            int tabansayi = 2;
            int üs_sayi = 3;

            // Math.Pow(2, 3) kullanarak sonuç
            double resultWithMathPow = Math.Pow(tabansayi, üs_sayi);
            Console.WriteLine("Sonuç Math.Pow Kullanarak: " + resultWithMathPow);

            // Kendi MyPower metoduyla sonuç
            int resultWithMyPower = MyPower(tabansayi, üs_sayi);
            Console.WriteLine("Sonuç Kendi Metodumu(MyPower) Kullanarak: " + resultWithMyPower);
        }
        public static int MyPower(int tabansayi, int üs_sayi)
        {
            if (üs_sayi < 0)//negatif olamaz
            {
                Console.WriteLine("Üs, negatif olmayan bir tamsayı olmalıdır.");
            }

            if (üs_sayi == 0)//kural gereği
            {
                return 1;
            }
            int result = tabansayi;
            for (int i = 1; i < üs_sayi; i++)
            {
                result *= tabansayi;
            }
            return result;
        }
    }
}
