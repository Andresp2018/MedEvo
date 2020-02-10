using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains
{
    public interface XNeuron
    {
        void AddSignal(double signal);

        void Update();

        double Activation { get; }
    }
}


