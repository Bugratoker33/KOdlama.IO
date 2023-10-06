namespace Koleksıyonlar
{
    class Program
    {
        static void Main(string[] args)
        {   //steak           // heaap      //{} =adres 
            //string[] isimler = new string[] {"engin ", "murat" , "kerekm ", "halil" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            // Generics başlangıcı



            //KOLEKSİYONLAR :::::::::::
            List<string> isimler2 = new List<string> { "Engin ", "Murat", "Kerekm ", "Halil" };
            Console.WriteLine(isimler2[0] );
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İKER");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            isimler2.Count() ;
            Console.WriteLine(isimler2.Count );

        }
    }
}