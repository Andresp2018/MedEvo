using MEDEvoBrains.Neurons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains.Synapses
{

    abstract public class MasterSynapse : XSynapse
    {
        protected XNeuron inNeuron;

        protected XNeuron outNeuron;

        protected double lowBound;

        protected double highBound;

        protected MasterSynapse(XNeuron outNeuron, XNeuron inNeuron, double lowBound, double highBound)
        {
            this.outNeuron = outNeuron;
            this.inNeuron = inNeuron;
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        protected virtual double CalculateSignal()
        {
            return 0;
        }

        protected virtual void Update()
        {
            inNeuron.AddSignal(Math.Min(highBound, Math.Max(lowBound, CalculateSignal())));
        }

        #region XSynapse Members

        void XSynapse.Update()
        {
            Update();
        }

        #endregion
    }
}
