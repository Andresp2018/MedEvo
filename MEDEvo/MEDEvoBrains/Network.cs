using MEDEvoBrains.Neurons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains
{
    public class Network<TNeuron, TSynapse> : XNetwork<TNeuron, TSynapse>
        where TNeuron : XNeuron
        where TSynapse : XSynapse
    {
        protected IReadOnlyList<TNeuron> neurons;
        protected IReadOnlyList<TSynapse> synapses;

        public Network(IReadOnlyList<TNeuron> neurons, IReadOnlyList<TSynapse> synapses)
        {
            this.neurons = neurons;
            this.synapses = synapses;
        }

        #region INetwork<TNeuron,TSynapse> Members

        public IReadOnlyList<TNeuron> Neurons
        {
            get { return neurons; }
        }

        public IReadOnlyList<TSynapse> Synapses
        {
            get { return synapses; }
        }

        void XNetwork < TNeuron, TSynapse>.Update()
        {
            foreach (var synapse in synapses)
                synapse.Update();
            foreach (var neuron in neurons)
                neuron.Update();
        }

        #endregion
    }
}