using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains.Neurons
{
    public interface XSynapse
    {
        /* Calcula um sinal de sinapse ponderado 
         * com base na saída de um neurônio e seu peso*/
        void Update();
    }
}

