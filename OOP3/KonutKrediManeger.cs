using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP3
{
    class KonutKrediManeger : IKrediManager
    {
        public void BirşeyYap()
        {
            Console.WriteLine("yapıyoruz");
        }

        public void Hesapla()
        {
            Console.WriteLine("konut kredisi ödeme planı hesaplandı");
        }
    }
}
