using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XCrossover<TChromosome, in TParentsPair>
    {

        IReadOnlyList<TChromosome> Crossover(TParentsPair parentsPair);
    }
}
