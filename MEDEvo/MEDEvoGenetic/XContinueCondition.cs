using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XContinueCondition<in TIndividual>
    {

        bool ShouldContinue(IReadOnlyList<TIndividual> population, int generation);
    }
}


