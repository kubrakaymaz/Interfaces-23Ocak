using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class TaşıtKrediManager:IKrediManager
    {
        void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme plannı hesaplandı");
        }
        void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
