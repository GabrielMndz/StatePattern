using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StatePattern
{
    public class StateValidado : IServerState
    {
        public void Procesa()
        {
            Thread.Sleep(3000);
            Console.WriteLine("El Pedido ha sido validado correctamente!");
        }
    }
}
