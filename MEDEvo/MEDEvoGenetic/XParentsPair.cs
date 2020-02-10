using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XParentsPair<out TIndividual>
    {

        TIndividual MotherCompound { get; }

        TIndividual FatherCompound { get; }
    }
}

