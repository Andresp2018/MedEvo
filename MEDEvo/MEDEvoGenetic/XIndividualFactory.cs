using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XIndividualFactory<TChromosome, out TIndividual>
    {
        TIndividual CreateIndividual(
            TChromosome chromosome,
            XFitnessFunction<TChromosome> fitnessFunction);
    }
}


