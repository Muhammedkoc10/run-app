using System;

namespace KosuMesafeOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            double adimUzunlugu = AdimUzunlugu();
            double dakikadaAdim = DakikadaKacAdim();
            double kosuSuresi = KosuSuresi();
            double hesapla = adimUzunlugu * dakikadaAdim * kosuSuresi;
            Console.WriteLine("Metre cinsinden koştuğunuz ilk mesafe  = " + hesapla + " metredir.");
            Console.WriteLine();
            Tekrarla(adimUzunlugu);
            Console.WriteLine("Programı kullandığınız için teşekkür eder sağlıklı günler dileriz :)");
            Console.ReadLine();
        }
        private static void  Tekrarla(double adimUzunlugu)
        {
            int sayac = 0;
            while (sayac <5)
            {
                Console.WriteLine("Buraya kadar yorulduğunu düşündük :) Temponuz değişebileceğinden dolayı sizden tekrar dakikada kaç adım koştuğunuzu ve koşacağınız süreyi girmenizi rica edeceğiz... Bu satırda ne kadar koşacağınızı girer misiniz?");
                Console.WriteLine();
                double kosuSure = KosuSuresi();
                Console.WriteLine("Şimdi ise dakikada kaç adıma düştüğünüzü/çıktığınızı yazmanızı rica edicez :)");
                double kacAdim = DakikadaKacAdim();
                double hesapla = kosuSure * kacAdim * adimUzunlugu;
                Console.WriteLine("Son koşunuzda katettiğiniz mesafe = "+hesapla+"metredir" );
                Console.WriteLine();
                sayac++;
            }
        }
        private static double KosuSuresi()
        {
            double toplamSure = 0;
            Console.WriteLine("Lütfen ilk koşu sürenizi saat cinsinden giriniz");
            bool dogruMu = double.TryParse(Console.ReadLine(), out double saatSure);
            Console.WriteLine("Lütfen ilk koşu sürenizi dakika cinsinden giriniz");
            bool dogruMu2 = double.TryParse(Console.ReadLine(), out double dakikaSure);

            if (dogruMu == true && dogruMu2 == true)
            {
                toplamSure = toplamSure + (saatSure * 60.0);
                
                return toplamSure = toplamSure + dakikaSure;
            }
            else
                return KosuSuresi();
        }

        private static double DakikadaKacAdim()
        {
            Console.WriteLine("Lütfen bir dakikada kaç adım koştuğunuz tam sayı cinsinden giriniz");
            bool dogruMu = double.TryParse(Console.ReadLine(), out double kacadim);

            if (dogruMu == true)
                return kacadim;
            else
                return DakikadaKacAdim();
        }
        private static double AdimUzunlugu()
        {
            Console.WriteLine("Koştuğunuz mesafeyi bulmanıza yarayan programımıza hoşgeldiniz...Lütfen bir adımınızı cm cinsinden giriniz");
            bool dogruMu = double.TryParse(Console.ReadLine(), out double adim);

            if (dogruMu == true)
                return adim;
            else
                return AdimUzunlugu();
        }
    }
}
