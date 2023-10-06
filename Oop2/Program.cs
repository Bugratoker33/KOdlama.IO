namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Buğra
           GerçekMusteri musteri1= new GerçekMusteri();

            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adı = "Buğra";
            musteri1.SoyAdi = "Toker";
            musteri1.TcNo = "12345678910";

            //kodlama.io

            TuzelMusteri musteri2= new TuzelMusteri();

            musteri2.Id = 2;    

            musteri2.MusteriNo="54321";

            musteri2.SirketAdı = "Kodalama.io";

            musteri2.VergiNo = "1234567890";
            

            Musteri musteri3 = new GerçekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            List<Musteri> musteris = new List<Musteri>()
            {
                musteri1 , musteri2 , musteri3 , musteri4

            };

            
           
            

            
            MusteriManeger musteriManeger= new MusteriManeger();

            musteriManeger.Ekle(musteri1,musteri1);
            musteriManeger = new MusteriManeger();
            musteriManeger.KrediOnBilgilendirmesiYap(musteris);

        }
    }
}