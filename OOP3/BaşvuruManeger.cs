using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BaşvuruManeger
    {
        //methode injection 

        public void BaşvuruYap(IKrediManager krediManager ,ILoggerService loggerService )
        {
            krediManager.Hesapla();
           //krediManager.BirşeyYap();
            loggerService.Log();
           
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler, List<ILoggerService> loggerservices)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                kredi.BirşeyYap();
            }
           foreach (var logger in loggerservices)
            {
                logger.Log();
            } 

            
        }
       
    }
}
