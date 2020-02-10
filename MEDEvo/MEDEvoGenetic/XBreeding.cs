using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XBreeding<in TIndividual, out TParentsPair>
    {

        IReadOnlyList<TParentsPair> Select(IReadOnlyList<TIndividual> population);
    }
}


