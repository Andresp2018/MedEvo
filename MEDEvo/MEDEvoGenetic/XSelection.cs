using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XSelection<TIndividual>
    {        
        IReadOnlyList<TIndividual> Select(IReadOnlyList<TIndividual> reproductionGroup, int count);
    }
}

