using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StatePattern
{
    class StateEntregado : IServerState
    {
        public void Procesa()
        {
            Thread.Sleep(5000);
            Console.WriteLine("El Pedido ha sido Entregado Sastifactoriamente!");
        }
    }
}
