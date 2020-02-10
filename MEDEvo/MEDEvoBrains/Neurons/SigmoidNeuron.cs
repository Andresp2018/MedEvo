using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains.Neurons
{
    public class SigmoidNeuron : MasterNeuron
    {

        protected double slope;

        #region Builder

        public SigmoidNeuron(double slope, double bias, double lowBound, double highBound)
            : base(bias, lowBound, highBound)
        {
            this.slope = slope;
        }

        public SigmoidNeuron(double slope, double bias)
            : this(slope, bias, double.NegativeInfinity, double.PositiveInfinity)
        {
        }

        public SigmoidNeuron(double slope, double lowBound, double highBound)
            : this(slope, 0, lowBound, highBound)
        {
        }

        public SigmoidNeuron(double slope)
            : this(slope, 0, double.NegativeInfinity, double.PositiveInfinity)
        {
        }

        #endregion

        protected override double CalculateActivation()
        {
            return bias + 1 / (1 - Math.Exp(-slope * summaryInput));
        }
    }
}

