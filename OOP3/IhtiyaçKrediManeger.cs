using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class IhtiyaçKrediManeger : IKrediManager
    {
        public void BirşeyYap()
        {
            Console.WriteLine("yapıyoruz");
        }

        public void Hesapla()
        {
            Console.WriteLine("ihtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
