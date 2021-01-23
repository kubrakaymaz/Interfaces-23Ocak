using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class EsnafKredisiManager:IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi ödeme plannı hesaplandı");
        }
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
