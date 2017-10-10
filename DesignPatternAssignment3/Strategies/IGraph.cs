using System.Collections.Generic;

namespace DesignPatternAssignment3
{
    interface IGraph
    {
        void DrawGraph(ICollection<ICoOrdinate> CoOrdinates);
        void SetData(ICollection<ICoOrdinate> CoOrdinates);
    }
}
