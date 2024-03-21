namespace ConsoleApp5
{
    internal class Program //zümrüt gemici görev4 ödevinin A-2 soru:
    {
        /*Substring metodunun 2 parametreli versiyonunu kendiniz yazın.
        (Bu metot için string veri de parametreden gönderilsin ve hiçbir System sınıfından string metot kullanılmasın.)*/
        static void Main(string[] args)
        {
            string isim = "Zümrüt Gemici";
            int startIndex = 7;//zümrüt 6 harfli bir de boşluk 7 oluyor
            int length = 6;

            string result = Substring(isim, startIndex, length);//metoda gönderdik
            Console.WriteLine(result); // Çıktı: gemici
        }

        static string Substring(string input, int startIndex, int length)
        {
            //metodu içinde, eğer başlangıç indis veya uzunluk geçerli olmayan bir değere sahipse
            if (startIndex < 0 || startIndex >= input.Length)//6<0 mı veya 7 büyük eşit isimin uzunluğundan
            {//Başlangıç indis, girdi dizesinin sınırları dışında olamaz
                Console.WriteLine(nameof(startIndex), "başlangıç dizisi aralık dışında.");
            }

            if (length < 0 || startIndex + length > input.Length)
            {//Uzunluk, negatif veya başlangıç indisinden sonraki karakterlerin sayısından fazla olamaz.
                Console.WriteLine("Uzunluk dizi dışında");
                return string.Empty;
            }

            char[] resultChars = new char[length];//alt dizeyi oluşturmak için gerekli olan karakterler dizisi
            for (int i = 0; i < length; i++)
            {
                resultChars[i] = input[startIndex + i];//atama yapıyoruz
            }
            //resultChars dizisi kullanılarak yeni bir dize oluşturuldu ve bu dize geri döndürüldü.
            return new string(resultChars);
        }
    }
}
