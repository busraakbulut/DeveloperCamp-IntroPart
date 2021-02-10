using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            // başvuran bilgilerinin alındığı bölümdür.

            //KonutKrediManager konutKrediManager = new KonutKrediManager-- eğer bunu böyle yapsaydık basvuru yap kısmında interface şeklinde kullanmasaydık 
            // buradaki işlemlerde doğal olarak sadece konut kredisi ile alakalı şeyler hesaplanabilecekti.

            krediManager.Hesapla(); // bu şekilde yazdığımızda zaten interface diğer alt tabanları kapsadığı için interface içerisinde bulunan tüm kredi şekillerine göre ayrı ayrı özel hesaplama yapılabilir.
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
