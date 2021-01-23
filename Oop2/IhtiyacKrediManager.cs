using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class IhtiyacKrediManager:IKrediManager
    {
        void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme plannı hesaplandı");
        }
        void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
