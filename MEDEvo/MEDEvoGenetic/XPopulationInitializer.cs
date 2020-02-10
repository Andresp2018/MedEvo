using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XPopulationInitializer<out TChromosome>
    {

        IReadOnlyList<TChromosome> Initialize();
    }
}


