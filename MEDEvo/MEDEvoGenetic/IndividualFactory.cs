using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public class IndividualFactory<TChromosome> :

        XIndividualFactory<TChromosome, Individual<TChromosome>>
    {
        #region XIndividualFactory<TChromosome,Individual<TChromosome>> Members

        Individual<TChromosome> XIndividualFactory<TChromosome, Individual<TChromosome>>.CreateIndividual(TChromosome chromosome, XFitnessFunction<TChromosome> fitnessFunction)
        {
            return new Individual<TChromosome>(chromosome, fitnessFunction);
        }

        #endregion
    }
}
