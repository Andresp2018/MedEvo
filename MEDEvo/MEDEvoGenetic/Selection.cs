using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    public abstract class Selection<TIndividual, TSelector>
         : XSelection<TIndividual>
    {
        public TSelector Selector { get; protected set; }

        protected Selection(TSelector selector)
        {
            Selector = selector;
        }

        protected abstract IReadOnlyList<TIndividual> DoSelection(IReadOnlyList<TIndividual> reproductionGroup, int count);

        #region XSelection<TChromosome,TIndividual> Members

        IReadOnlyList<TIndividual> XSelection<TIndividual>.Select(IReadOnlyList<TIndividual> reproductionGroup, int count)
        {
            if (count == 0)
                return new List<TIndividual>(0);

            return DoSelection(reproductionGroup, count);
        }

        #endregion
    }
}

