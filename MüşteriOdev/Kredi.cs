using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MüşteriOdev
{
    class Kredi
    {
        public void Krediver(Customer customer)
        {
            Console.WriteLine("başarıyla kredi verilmiştir");

           Console.WriteLine("kredi verilen kişinin ismi" + " " + customer.Name);
            Console.WriteLine("kredi verilen kişinin soy isi" + " " + customer.Surname);
            Console.WriteLine("kredi verilen kişinin geliri " + " " + customer.Gelir);
            Console.WriteLine("kredi verilen kişinin kimlği" + " " + customer.Id);


        }
    }
}
