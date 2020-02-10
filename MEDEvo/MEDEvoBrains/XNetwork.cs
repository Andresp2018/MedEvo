using MEDEvoBrains.Neurons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains
{
    public interface XNetwork<out TNeuron, out TSynapse>
        where TNeuron : XNeuron
        where TSynapse : XSynapse
    {

        IReadOnlyList<TNeuron> Neurons { get; }

        IReadOnlyList<TSynapse> Synapses { get; }

        void Update();
    }
}