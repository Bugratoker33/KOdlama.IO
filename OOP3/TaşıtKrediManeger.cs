using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TaşıtKrediManeger : IKrediManager
    {
        public void BirşeyYap()
        {
            Console.WriteLine("yapıyoruz");
        }

        public void Hesapla()
        {
            Console.WriteLine("taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
