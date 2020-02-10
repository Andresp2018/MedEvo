using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public class Individual<TChromosome>
       : XIndividual<TChromosome>
    {

        public XFitnessFunction<TChromosome> FitnessFunction { get; protected set; }

        public Individual(
            TChromosome chromosome,
            XFitnessFunction<TChromosome> fitnessFunction)
        {
            Chromosome = chromosome;
            FitnessFunction = fitnessFunction;
            RecalculateFitness();
        }

        #region XIndividual<TChromosome> Members

        public double Fitness { get; protected set; }

        public TChromosome Chromosome { get; protected set; }

        public void RecalculateFitness()
        {
            Fitness = FitnessFunction.Calculate(Chromosome);
        }

        #endregion
    }
}
}
