using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oop2
{// iş sınıfları //MANEGER SINIFLARI
    class MusteriManeger
    {
        public void Ekle(Musteri musteri, GerçekMusteri gerçekMusteri)
        {



            Console.WriteLine(gerçekMusteri.Adı);



            //  Console.WriteLine(musteri.ToString());


        }
        public void KrediOnBilgilendirmesiYap(List<Musteri> krediler)
        {
            foreach (var musteri in krediler)
            {
                Console.WriteLine(musteri.MusteriNo);
            }

        }
    }
}
