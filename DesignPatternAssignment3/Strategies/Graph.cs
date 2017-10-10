using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment3
{
    abstract class Graph : IGraph
    {
        private ICollection<ICoOrdinate> _data;
        public abstract void DrawGraph(ICollection<ICoOrdinate> CoOrdinates);
        public void SetData(ICollection<ICoOrdinate> data)
        {
            this._data = data;
        }

    }
}
