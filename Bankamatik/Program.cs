internal class Program
{
    static double bakiye = 2000;

    private static void Main(string[] args)
    {

        Console.WriteLine("SAFA Banka Hoşgeldiniz...\n" +
            "1-Bakiye Sorgulama\n" +
            "2-Para Çekme\n" +
            "3-Para Yatırma\n" +
            "4-Çıkış");
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.(1-4)");
        int secim = int.Parse(Console.ReadLine());
        Console.WriteLine(secim);
        switch (secim)
        {
            case 1:
                BakıyeSorgulama();
                break;
            case 2:
                ParaCekme();
                break;
            case 3:
                ParaYatirma();
                break;
            case 4:
                Console.WriteLine();
                break;
            case 5:
                Console.WriteLine("deneme");
                break;
            default:
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                break;


        }
    }
    static void BakıyeSorgulama()
    {
        Console.WriteLine("Bakiyeniz: " + bakiye);
    }
    static void ParaYatirma()
    {
        try
        {
            Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz.");
            double YatirilacakTutar = Convert.ToDouble(Console.ReadLine());

            if (YatirilacakTutar > 0)
            {
                bakiye += YatirilacakTutar;
                Console.WriteLine(YatirilacakTutar + " tutar hesabınıza yatırıldı.Güncel Bakiyeniz:" + bakiye);
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir tutar giriniz.");
            }


        }
        catch (Exception)
        {
            Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            ParaYatirma();

        }
    

    }
    static void ParaCekme()
    {
        try
        {
            Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz.");
            double CekilecekTutar = Convert.ToDouble(Console.ReadLine());

            if (CekilecekTutar > 0 && CekilecekTutar<2000)
            {
                bakiye -= CekilecekTutar;
                Console.WriteLine(CekilecekTutar + " tutar çekildi.Güncel Bakiyeniz:" + bakiye);
               
            }
            

            else if (CekilecekTutar > 2000)
            {
                Console.WriteLine("Çekilecek tutar 2000 TL. geçemez. Lütfen geçerli bir tutar giriniz.");
                ParaCekme();
            }
            else if (CekilecekTutar > bakiye)
            {
                Console.WriteLine("Bakiyeniz yetersiz!!! \n" +
                    "Çekilmek istenen tutar" + CekilecekTutar + "Bakiyeniz:" + bakiye);
              

           }
            else
            {
                Console.WriteLine("Lütfen geçerli bir tutar giriniz.");
            }


        }
        catch (Exception)
        {
            Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            ParaCekme();

        }


    }
    

}
