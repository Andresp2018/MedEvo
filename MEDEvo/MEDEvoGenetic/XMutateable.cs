using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XMutateable<out T>
    {
        T Mutate();
    }
}
