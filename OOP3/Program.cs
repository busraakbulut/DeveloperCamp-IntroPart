using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();// burada base caseimizi interface olarak implement etmemiz bir şeyi değiştirmediğini anlayabiliriz.
            // tıpkı base classlar gibi interfacelerde girilen diğer aynı türdeki children(base case parent olarak düşünülürse) referans değerlerini tutar.
            konutKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService fileLoggerService = new FileLoggerService();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {konutKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
