using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XParentsPairFactory<in TIndividual, out TParentsPair>
    {

        TParentsPair CreatePair(TIndividual motherCompound, TIndividual fatherCompound);
    }
}

