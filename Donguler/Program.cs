using System;

namespace ödevkamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.ProductAdi = "Evde Spor";
            urun1.ProductTipi = "Pilates & Yoga";
            urun1.ProductMarka = "Delta Spor";
            urun1.ProductFiyati = 200;

            Product urun2 = new Product();
            urun2.ProductAdi = "Halı";
            urun2.ProductTipi = "kilim";
            urun2.ProductMarka = "Vivense Collection";
            urun2.ProductFiyati = 159;

            Product urun3 = new Product();
            urun3.ProductAdi = "Çalışma Odası";
            urun3.ProductTipi = "Çalışma Masası";
            urun3.ProductMarka = "Novak Ahşap Çalışma Masası";
            urun3.ProductFiyati = 500;

            Product[] urunler = new Product[] {urun1,urun2,urun3};

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("{0}",urunler[i]);
            }
            Console.WriteLine("for döngüsü bitti");
            foreach (var urun in urunler)
            {
                Console.WriteLine("{0}",urun.ProductAdi + " : " + urun.ProductTipi + " : " + urun.ProductMarka + " : " + urun.ProductFiyati);
            }
            Console.WriteLine("foreach döngüsü bitti");
            int urunn = 1;
            while (urunn <= urunler.Length)
            {
                Console.WriteLine("{0}",urunn);
                urunn++;
            }
        }
    }
    class Product
    {
        public string ProductAdi { get; set; }
        public string ProductTipi { get; set; }
        public string ProductMarka { get; set; }
        public int ProductFiyati { get; set; }
    }
}