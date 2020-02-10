using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XIndividual<out TChromosome>
    {

        double Fitness { get; }

        TChromosome Chromosome { get; }

        void RecalculateFitness();
    }
}

