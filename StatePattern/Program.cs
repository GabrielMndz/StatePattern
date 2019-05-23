using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaEstado oMaquina = new MaquinaEstado();

            oMaquina.State = new StateEnCurso();
            oMaquina.Solicita();
            Console.WriteLine();

            oMaquina.State = new StateValidado();
            oMaquina.Solicita();
            Console.WriteLine();

            oMaquina.State = new StateEntregado();
            oMaquina.Solicita();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
