using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains.Synapses
{
    public class HebbianSynapse : MasterSynapse
    {

        protected double weight;

        protected double learningRate;

        #region Builder
 
        public HebbianSynapse(XNeuron outNeuron, XNeuron inNeuron, double weight, double learningRate, double lowBound, double highBound)
            : base(outNeuron, inNeuron, lowBound, highBound)
        {
            this.weight = weight;
            this.learningRate = learningRate;
        }

        public HebbianSynapse(XNeuron outNeuron, XNeuron inNeuron, double weight, double learningRate)
            : this(outNeuron, inNeuron, weight, learningRate, double.NegativeInfinity, double.PositiveInfinity)
        {
        }

        #endregion

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double LearningRate
        {
            get { return learningRate; }
            set { learningRate = value; }
        }

        protected override void Update()
        {
            weight += inNeuron.Activation * outNeuron.Activation * learningRate;
            CalculateSignal();
        }

        protected override double CalculateSignal()
        {
            return outNeuron.Activation * weight;
        }
    }
}
