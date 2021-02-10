using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri:Musteri // iki nokta koyup sonrasında müşteri yazmamız bunu bir nevi bir db bağlamış oluyor (bence) buna da inheritance deniyor.
    {
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        
    }
}
