using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlarr
{
    class SepetManeger
    {
        // methot nasıl yazılır :
        // public void ekle bir methotdur ve süslü parantezin içindeki methotlarımızdır::
        public void Ekle(Urun urun) // parametre veriyorz 
        {
           
            Console.WriteLine("Sepete eklendi : "+urun.Adı);
            Console.WriteLine("sepete eklenen ürünün açıklaması : " + urun.Acıklama);
            Console.WriteLine("ürün fiyatı : " + urun.Fıyatı);



        }

        public void Ekle2(string urunAdı,string açıklama,double fiyat)
        {
            Console.WriteLine("Tebriikler sepete eklendi" +" "+ urunAdı);

        }

    }
}
