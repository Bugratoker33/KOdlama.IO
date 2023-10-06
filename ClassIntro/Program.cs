

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "buğra";
            int yaş =21;


            kurs kurs1 =new kurs();
            kurs1.KursAdı = "c sharp";
            kurs1.Egitmen = "Buğra Toker";
            kurs1.IzlenmeOranı = 87;

            kurs kurs2 = new kurs();
            kurs2.KursAdı = "pyhton";
            kurs2.Egitmen ="Emirhan Toker";
            kurs2.IzlenmeOranı = 78;
           
            kurs kurs3 = new kurs();
            kurs3.KursAdı = "C++";
            kurs3.Egitmen = "Emir Toker";
            kurs3.IzlenmeOranı = 68;


            // Console.WriteLine(kurs1.KursAdı + " " + kurs1.Egitmen);

            kurs[] kurslar= new kurs[] { kurs1,kurs2,kurs3 };

           
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı+" : "+ kurs.Egitmen);
            }

            //
            //Console.WriteLine(kurslar);


            //Console.WriteLine("Hello, World!");
        }
    }
    class kurs 
    {
        public string KursAdı { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOranı { get; set; }






    }

}