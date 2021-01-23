using Oop3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class IhtiyacKrediManager:IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme plannı hesaplandı");
        }
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
