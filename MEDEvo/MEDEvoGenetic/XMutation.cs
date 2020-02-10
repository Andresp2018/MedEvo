using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XMutation<TChromosome>
    {
        TChromosome Mutate(TChromosome chromosome);
    }
}
