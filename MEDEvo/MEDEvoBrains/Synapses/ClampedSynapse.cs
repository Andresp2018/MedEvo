using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains.Synapses
{
    public class ClampedSynapse : MasterSynapse
    {

        protected double weight;

        #region Builder

        public ClampedSynapse(XNeuron outNeuron, XNeuron inNeuron, double weight, double lowBound, double highBound)
            : base(outNeuron, inNeuron, lowBound, highBound)
        {
            this.weight = weight;
        }

        public ClampedSynapse(XNeuron outNeuron, XNeuron inNeuron, double weight)
            : this(outNeuron, inNeuron, weight, double.NegativeInfinity, double.PositiveInfinity)
        {
        }

        #endregion

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        protected override double CalculateSignal()
        {
            return outNeuron.Activation * weight;
        }
    }
}

