using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XGeneticAlgorithm<out TChromosome, out TIndividual>
    {
        TIndividual Run(XFitnessFunction<TChromosome> fitnessFunction);
    }
}
