using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public abstract class Mutation<TChromosome>
         : XMutation<TChromosome>
    {

        public double Probability { get; protected set; }

        protected Mutation(double probability)
        {
            Probability = probability;
        }

        protected abstract TChromosome DoMutation(TChromosome chromosome);

        #region XMutation<TChromosome> Members

        TChromosome XMutation<TChromosome>.Mutate(TChromosome chromosome)
        {
            if (Util.Random.NextDouble() <= Probability)
                return DoMutation(chromosome);

            return chromosome;
        }

        #endregion
    }
}


