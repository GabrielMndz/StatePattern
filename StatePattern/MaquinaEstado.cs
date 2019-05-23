using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class MaquinaEstado
    {
        private IServerState state;

        public IServerState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public void Solicita()
        {
            state.Procesa();
        }
    }
}
