using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public interface XEqualityComparable<in T>
    {
        bool EqualsTo(T otherObject);
    }
}
