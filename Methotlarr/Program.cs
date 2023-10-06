namespace Methotlarr
{
    class Program
    {
        static void Main(string[] args)
        {
            // calasın nesnesi // clasdan değişken tamımlama 
            //claslar ikiye ayrılır içersinde özelik olan claslar (urun) ve içerisinde operasyon olan claslar (methotlar )

            Urun urun1 = new Urun();
            urun1.Adı = "elma";
            urun1.Fıyatı = 15;
            urun1.Acıklama = "amasya elması";


            Urun urun2 = new Urun();
            urun2.Adı = "karpuz";
            urun2.Fıyatı=80;
            urun2.Acıklama = "Diyarbakır Karpuzu";
            urun2.StokAdedı = 10;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            // type safe tip güvenliği çalışacağım veri tipini bilmek istterim 
            foreach (Urun urun in urunler)
            {
                
                Console.WriteLine( "urun adı"+": "+ urun.Adı);
                Console.WriteLine("urun fiyatı"+": "+urun.Fıyatı);
                Console.WriteLine("urun açıklaması "+": "+ urun.Acıklama);
                Console.WriteLine("Stok adedi" + ": " + urun.StokAdedı);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("---------------Methotlar---------------");

            SepetManeger sepetManager = new SepetManeger(); // lazım olan clasları nesnesini oluşturarak kulanabiliyoruz ::

            sepetManager.Ekle(urun1); // methodu bu şekilde çağrılır :;
            sepetManager.Ekle(urun2);
            Console.WriteLine( "******************************************" );
            // ******** : ekle2 aranan yazılımcı kuralarına aykırı : ********
            sepetManager.Ekle2("armut", "yeşil", 25);
            sepetManager.Ekle2("elma", "yeşil elma", 5);
            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 250);


            Console.WriteLine("Ürün temsilcisi"+" = "+"Buğra ** Toker!");
        }
    }
}