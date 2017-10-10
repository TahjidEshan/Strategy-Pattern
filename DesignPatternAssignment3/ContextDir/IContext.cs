using System.Collections.Generic;

namespace DesignPatternAssignment3
{
    interface IContext
    {
        void GraphDrawingAlgorithmInterface();
        ICollection<ICoOrdinate> CoOrdinates { get; set; }
        void AddCoOrdinates(ICoOrdinate value);
        void SetStrategy(IGraph Graph);
    }
}
