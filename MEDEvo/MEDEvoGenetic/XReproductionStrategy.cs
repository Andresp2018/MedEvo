using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XReproductionStrategy<TIndividual>
    {
        IReadOnlyList<TIndividual> NextGeneration(IReadOnlyList<TIndividual> population, IReadOnlyList<TIndividual> reproductionGroup);
    }
}