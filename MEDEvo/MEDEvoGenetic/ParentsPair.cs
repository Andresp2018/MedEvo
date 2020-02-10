using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public class ParentsPair<TIndividual>
          : XParentsPair<TIndividual>
    {
        public ParentsPair(TIndividual motherCompound, TIndividual fatherCompound)
        {
            MotherCompound = motherCompound;
            FatherCompound = fatherCompound;
        }

        #region IParentsPair<TChromosome, TIndividual> Members

        public TIndividual MotherCompound { get; protected set; }

        public TIndividual FatherCompound { get; protected set; }

        #endregion
    }
}
