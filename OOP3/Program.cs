namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyaçKrediManeger= new IhtiyaçKrediManeger();          
            IKrediManager taşıtKrediManeger = new TaşıtKrediManeger();           
            IKrediManager konutKrediManeger     = new KonutKrediManeger();
           IKrediManager  esnafkredisi= new EsnafKredisiManager();
            ILoggerService fileLoggerservice = new FileLoggerService();
            ILoggerService databaseloggerservice = new DataBaseLoggerService();
            ILoggerService smsloggerservices= new SmsLoggerService();

            BaşvuruManeger başvuruManeger = new BaşvuruManeger();
            //  başvuruManeger.BaşvuruYap(esnafkredisi, new SmsLoggerService()) ;

            List<IKrediManager> krediler= new List<IKrediManager>() {ihtiyaçKrediManeger,taşıtKrediManeger,konutKrediManeger,esnafkredisi };
            List<ILoggerService> loggerr = new List<ILoggerService>() { databaseloggerservice, fileLoggerservice,smsloggerservices };


            başvuruManeger.KrediOnBilgilendirmesiYap(krediler , loggerr);

          


            // interfaclerde o interface implamente eden o klasın referans numarasıı tutabiliyormuş  implament örnek:örnekler

        }
    }
}