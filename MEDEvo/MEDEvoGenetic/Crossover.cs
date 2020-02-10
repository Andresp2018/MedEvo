using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    class Crossover
    {
        public abstract class Crossover<TChromosome, TParentsPair>
       : XCrossover<TChromosome, TParentsPair>
        {

            public double Probability { get; protected set; }

            protected Crossover(double probability)
            {
                Probability = probability;
            }


            protected abstract IReadOnlyList<TChromosome> DoCrossover(TParentsPair parentsPair);


            #region ICrossover<TChromosome,TIndividual,TParentsPair> Members

            IReadOnlyList<TChromosome> XCrossover<TChromosome, TParentsPair>.Crossover(TParentsPair parentsPair)
            {
                if (Util.Random.NextDouble() <= Probability)
                    return DoCrossover(parentsPair);

                return new List<TChromosome>();
            }

            #endregion
        }
    }
}

