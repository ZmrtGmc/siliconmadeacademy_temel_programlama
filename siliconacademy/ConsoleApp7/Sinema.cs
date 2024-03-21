using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Sinema
    {
        public string FilmAdı;
        public int Kapasite;
        public int TamBiletFiyati;
        public int YarimBiletFiyati;
        public int ToplamTamBiletAdedi;
        public int ToplamYarıimBiletAdeti;
        public float Ciro;


        public Sinema(string filmAdı, int kapasite, int tam, int yarim)
        {
            this.FilmAdı = filmAdı;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tam;
            this.YarimBiletFiyati = yarim;
        }

        public void BiletSatisi(int tamBiletAdedi, int yarimBiletAdeti)
        {
            this.ToplamTamBiletAdedi += tamBiletAdedi;
            this.YarimBiletFiyati += yarimBiletAdeti;

            Console.WriteLine("İşlem Gerçekleştirildi.");
        }

        public void Biletİade(int tamBiletAdedi, int yarimBiletAdeti)
        {
            this.ToplamTamBiletAdedi -= tamBiletAdedi;
            this.YarimBiletFiyati -= yarimBiletAdeti;

            Console.WriteLine("İşlem Gerçekleştirildi.");
        }

        public void CiroHesap()
        {
            this.Ciro = this.ToplamTamBiletAdedi * this.TamBiletFiyati + 
                this.ToplamYarıimBiletAdeti * this.YarimBiletFiyati;
        }
    }


}
