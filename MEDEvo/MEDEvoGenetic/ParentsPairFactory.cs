using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public class ParentsPairFactory<TIndividual>
       : XParentsPairFactory<TIndividual, ParentsPair<TIndividual>>
    {
        #region XParentsPairFactory<TChromosome,TIndividual,ParentsPair<TChromosome,TIndividual>> Members

        ParentsPair<TIndividual> XParentsPairFactory<TIndividual, ParentsPair<TIndividual>>.CreatePair(TIndividual motherCompound, TIndividual fatherCompound)
        {
            return new ParentsPair<TIndividual>(motherCompound, fatherCompound);
        }

        #endregion
    }
}


