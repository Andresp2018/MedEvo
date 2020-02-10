using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains.Neurons
{
    public abstract class MasterNeuron : XNeuron
    {
        
        protected double bias;

        protected double lowBound;

        protected double highBound;

        protected double summaryInput;

        protected double activation;


        protected MasterNeuron(double bias, double lowBound, double highBound)
        {
            this.bias = bias;
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        protected virtual double CalculateActivation()
        {
            return 0;
        }

        protected virtual void AddSignal(double weight)
        {
            summaryInput += weight;
        }

        protected virtual void Update()
        {
            activation = Math.Min(highBound, Math.Max(lowBound, CalculateActivation()));
            summaryInput = 0;
        }

        #region XNeuron Members

        void XNeuron.AddSignal(double weight)
        {
            AddSignal(weight);
        }

        void XNeuron.Update()
        {
            Update();
        }

        public double Activation
        {
            get { return activation; }
        }

        #endregion
    }
}