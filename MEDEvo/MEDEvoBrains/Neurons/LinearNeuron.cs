using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains.Neurons
{
    public class LinearNeuron : MasterNeuron
    {

        protected double slope;

        #region Builder

        public LinearNeuron(double slope, double bias, double lowBound, double highBound)
            : base(bias, lowBound, highBound)
        {
            this.slope = slope;
        }

        public LinearNeuron(double slope, double bias)
            : this(slope, bias, double.NegativeInfinity, double.PositiveInfinity)
        {
        }

        public LinearNeuron(double slope, double lowBound, double highBound)
            : this(slope, 0, lowBound, highBound)
        {
        }

        public LinearNeuron(double slope)
            : this(slope, 0, double.NegativeInfinity, double.PositiveInfinity)
        {
        }

        #endregion

        protected override double CalculateActivation()
        {
            return (summaryInput + bias) * slope;
        }
    }
}


