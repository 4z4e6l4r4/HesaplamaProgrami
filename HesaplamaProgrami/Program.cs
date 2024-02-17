namespace HesaplamaProgrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hesaplama();
        }

        public static void Hesaplama()
        {
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("-------- Hesaplama Programı --------\n"+
                "------------------------------------\n" +
                "-------- Hesaplama Seçiniz ---------\n"+
                "------------------------------------\n"+
                "Basit Hesap Makinesi_____________(1)\n"+
                "Dairenin Alan Hesaplaması________(2)\n" +
                "Dairenin Çevre Hesaplaması_______(3)\n" +
                "Dikdörtgen Alan Hesaplaması______(4)\n" +
                "Dikdörtgen Çevre Hesaplaması_____(5)\n" +
                "Çıkış Yap________________________(0)\n");

                Console.Write("Seçiminiz: ");

                int secim = Convert.ToInt32(Console.ReadLine());

                Program program = new Program();

                switch (secim)
                {
                    case 1:
                        program.BasitHesapMakinesi();
                        break;
                    case 2:
                        program.DaireninAlanHesaplaması();
                        Console.WriteLine("Dairenin Alan Hesaplaması");
                        break;
                    case 3:
                        program.DaireninCevreHesaplaması();
                        Console.WriteLine("Dairenin Çevre Hesaplaması");
                        break;
                    case 4:
                        program.DikdortgenAlanHesaplaması();
                        Console.WriteLine("Dikdörtgenin Alan Hesaplaması");
                        break;
                    case 5:
                        program.DaireninCevreHesaplaması();
                        Console.WriteLine("Dikdörtgenin Çevre Hesaplaması");
                        break;
                    case 0:
                        Console.WriteLine("Çıkış Yapılıyor....");
                        durum = false;
                        break;
                    default:
                        Console.WriteLine("Tanımsız Seçim Yapıldı Tekrar Deneyiniz.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void BasitHesapMakinesi()
        {
            Console.Clear();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("------- Basit Hesap Makinesi -------\n" +
                "------------------------------------\n" +
                "Üst Menüye Geç___________________(E)\n");

                Console.Write("1. Sayı: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2. Sayı: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Operatör Seçiniz ( + - * / % ): ");
                string oprt = Console.ReadLine();
                oprt = oprt.Substring(0, 1);

                double sonuc = 0;
                switch (oprt)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);

                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);

                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);

                        break;
                    case "/":
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);

                        break;
                    case "%":
                        sonuc = sayi1 % sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);

                        break;
                    case "E":
                        Console.WriteLine("Üst Menüye Geçiliyor...");
                        durum = false;
                        break;
                    default:
                        Console.WriteLine("Tanımsız Operatör Seçildi.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void DaireninAlanHesaplaması()
        {
            Console.Clear();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("------- Dairenin Alan Hesaplaması -------\n" +
                "------------------------------------\n" +
                "Üst Menüye Geç___________________(0)\n");

                Console.Write("Dairenin Yarı çapını giriniz (r): ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                double sonuc = 0;
                        double sonuc1 = 3*sayi1*sayi1;
                        Console.WriteLine("Sonuç: " + sonuc1);

                if (sayi1 == 0)
                {
                    Console.WriteLine("Bir üst menüye geçilecek..");
                    durum = false;                
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        public void DaireninCevreHesaplaması()
        {
            Console.Clear();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("------- Dairenin Çevre Hesaplaması -------\n" +
                "------------------------------------\n" +
                "Üst Menüye Geç___________________(E)\n");

                Console.Write("Dairenin Uzun Kenarını giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Dairenin Kısa Kenarını giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double sonuc = 0;
                double sonuc1 = 2*(sayi2+sayi1);
                Console.WriteLine("Sonuç: " + sonuc1);

                if (sayi1 == 0)
                {
                    Console.WriteLine("Bir üst menüye geçilecek..");
                    durum = false;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        public void DikdortgenAlanHesaplaması()
        {
            Console.Clear();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("------- Dikdörtgen Alan Hesaplaması -------\n" +
                "------------------------------------\n" +
                "Üst Menüye Geç___________________(E)\n");

                Console.Write("Dairenin Uzun Kenarını giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Dairenin Kısa Kenarını giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double sonuc = 0;
                double sonuc1 = sayi1*sayi2;
                Console.WriteLine("Sonuç: " + sonuc1);

                if (sayi1 == 0)
                {
                    Console.WriteLine("Bir üst menüye geçilecek..");
                    durum = false;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        public void DikdortgenCevreHesaplaması()
        {
            Console.Clear();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("------- Dikdörtgen Çevre Hesaplaması -------\n" +
                "------------------------------------\n" +
                "Üst Menüye Geç___________________(E)\n");

                Console.Write("Dairenin Uzun Kenarını giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Dairenin Kısa Kenarını giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double sonuc = 0;
                double sonuc1 = 2*(sayi1+sayi2);
                Console.WriteLine("Sonuç: " + sonuc1);

                if (sayi1 == 0)
                {
                    Console.WriteLine("Bir üst menüye geçilecek..");
                    durum = false;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }







    }
}