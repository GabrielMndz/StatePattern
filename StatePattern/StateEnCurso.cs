using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class StateEnCurso : IServerState
    {
        public void Procesa()
        {
            Console.WriteLine("Introduzca su pedido: ");
            string pedido = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("El Pedido '" + pedido + "' esta en Curso de Creacion!");
        }
    }
}
