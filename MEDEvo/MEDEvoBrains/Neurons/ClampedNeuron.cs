using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoBrains.Neurons
{
    public class ClampedNeuron : XNeuron
    {

        protected double activation;

        public ClampedNeuron(double activation)
        {
            this.activation = activation;
        }

        #region XNeuron Members

        void XNeuron.AddSignal(double weight)
        {
        }

        void XNeuron.Update()
        {
        }


        public double Activation
        {
            get { return activation; }
            set { activation = value; }
        }

        #endregion
    }
}


