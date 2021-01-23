using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class KonutKrediManager : IKrediManager
    {
        void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme plannı hesaplandı");
        }
        void BiseyYap()
        {
            throw new NotImplementedException();
        }

    }
}
